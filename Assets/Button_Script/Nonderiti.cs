using UnityEngine;
using UnityEngine.SceneManagement;


public class Nonderiti : MonoBehaviour
{
    [SerializeField] private int nonderiti = 0;  

    private int TotalNonderi;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        nonderiti += 1;
        Debug.Log(nonderiti);
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