using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Button a;
    public Button b;
    public Button c;

    [SerializeField] private string nextSceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定
    }
    void Start()
    {
        if (a != null)
        {
            a.onClick.AddListener(ChangeScene);
        }
        if (b != null)
        {
            b.onClick.AddListener(ChangeScene);
        }
        if (c != null)
        {
            c.onClick.AddListener(ChangeScene);
        }
    }

}