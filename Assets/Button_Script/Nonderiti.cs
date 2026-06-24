using UnityEngine;
using UnityEngine.SceneManagement;


public class Nonderiti : MonoBehaviour
{
    [SerializeField] private static int nonderiti = 20;   

    private int TotalNonderi;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void OnClick()
    {
        TotalNonderi += nonderiti;

        if (TotalNonderi >= 100)
        {
            TotalNonderi = 100;
        }

        Debug.Log(TotalNonderi);

    }
}