using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMove _playerMove;

    /// <summary>
    /// 初期化
    /// </summary>
    public void Initialize()
    {
        _playerMove = GetComponent<PlayerMove>();
        _playerMove.Initialize();
    }

    /// <summary>
    /// 更新
    /// </summary>
    public void UpdatePlayer()
    {
        _playerMove.Walk();
    }
}
