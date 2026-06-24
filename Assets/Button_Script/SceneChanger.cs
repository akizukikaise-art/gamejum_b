using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Button a;
    public Button b;
    public Button c;

    [SerializeField] private string nextSceneName;
    //public void ChangeScene()
    //{
    //    SceneManager.LoadScene(nextSceneName); // シーン名で指定
    //}
    private void Start()
    {
        if (a != null)
        {
            SceneManager.LoadScene(nextSceneName); // シーン名で指定
        }
        if (b != null)
        {
            SceneManager.LoadScene(nextSceneName); // シーン名で指定
        }
        if (c != null)
        {
            SceneManager.LoadScene(nextSceneName); // シーン名で指定
        }

    }
}