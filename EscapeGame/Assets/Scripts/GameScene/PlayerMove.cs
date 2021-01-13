using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.0f; // 移動速度
    [SerializeField] private float _maxSpeed  = 0.0f; // 最高速度
    
    private Rigidbody _rigidbody; // リジッドボディ

    /// <summary>
    /// 初期化
    /// </summary>
    public void Initialize()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 歩く
    /// </summary>
    public void Walk()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0.0f, z);
        if (!IsMaxSpeed())
        {
            _rigidbody.AddForce(dir.normalized * _moveSpeed * 100.0f * Time.deltaTime);
        }
    }

    /// <summary>
    /// 最高速度か判定
    /// </summary>
    /// <returns></returns>
    private bool IsMaxSpeed()
    {
        if (_rigidbody.velocity.sqrMagnitude >= _maxSpeed * _maxSpeed) return true;
        return false;
    }
}
