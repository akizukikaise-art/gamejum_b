using UnityEngine;
using UnityEngine.SceneManagement;

public class A_Nonderiti : MonoBehaviour
{
    public int nonderiti;                // このボタンの点数
    public A_DataKeep datakeep;

    public void OnClick()
    {
        A_DataKeep.Instance.AddNonderiti(nonderiti);
    }
}