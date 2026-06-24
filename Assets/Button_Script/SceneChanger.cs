using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public Button a;
    public Button B;
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
    }

}