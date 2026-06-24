using UnityEngine;
using UnityEngine.SceneManagement;


public class DataKeep : MonoBehaviour
{

    public static int nonderiti = 20;
    [SerializeField] private string nextSceneName;


    private int TotalNonderi;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void OnClick()
    {
        TotalNonderi += nonderiti;

        if (TotalNonderi >= 100) TotalNonderi = 100;

        Debug.Log(TotalNonderi);
    }


    //シーンの切り換え
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

}
