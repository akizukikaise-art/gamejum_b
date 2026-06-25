using UnityEngine;
using UnityEngine.SceneManagement;

public class A_SceneChanger : MonoBehaviour
{
    [SerializeField] private string nextSceneName;
    public void SceneChange()
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定

    }

}
