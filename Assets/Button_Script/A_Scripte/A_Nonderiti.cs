using UnityEngine;
using UnityEngine.SceneManagement;

public class A_Nonderiti : MonoBehaviour
{
    private A_DataKeep datakeep;

    private void Awake()
    {
        datakeep = GameObject.FindAnyObjectByType<A_DataKeep>();
    }

    public void OnClick(int nonderiti)
    {
        A_DataKeep.Instance.AddNonderiti(nonderiti);
    }
}