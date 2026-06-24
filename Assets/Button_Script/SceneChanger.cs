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
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定
    }
}