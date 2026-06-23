using UnityEngine;

public class Nonderiti : MonoBehaviour
{

    [SerializeField] private int nonderiti;

    private int TotalNonderi;

    //ボタンを押した時に数値を変える
    public void OnClick()
    {
        TotalNonderi += nonderiti;

        Debug.Log(TotalNonderi);
    }

}
