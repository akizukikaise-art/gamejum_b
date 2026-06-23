using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //変数宣言
    //シーン名
    [SerializeField] private string nextSceneName;

    //シーンの切り換え
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}