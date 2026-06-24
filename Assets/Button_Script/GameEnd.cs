using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // エディタ上での停止
#else
        Application.Quit(); // ビルド後のゲーム終了
#endif
    }
}