using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    TitleScene,     // タイトルシーン 
    GameScene,      // ゲームシーン
    ResultScene,    // リザルトシーン
}

public class SceneController : MonoBehaviour
{
    /// <summary>
    /// シーン遷移
    /// </summary>
    /// <param name="scene">遷移するシーン</param>
    public static void ChangeScene(SceneType scene)
    {
        string name = scene.ToString();
        SceneManager.LoadScene(name);
    }
}
