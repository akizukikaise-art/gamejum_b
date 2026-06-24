using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject gameObject;
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