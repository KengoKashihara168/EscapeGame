using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player _player = null;

    // Start is called before the first frame update
    void Start()
    {
        _player.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _player.UpdatePlayer();

        // エンターキーを押したらリザルトシーンへ遷移する
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneController.ChangeScene(SceneType.ResultScene);
        }
    }
}
