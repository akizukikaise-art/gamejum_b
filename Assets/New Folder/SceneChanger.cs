using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string nextSceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定
    }
}