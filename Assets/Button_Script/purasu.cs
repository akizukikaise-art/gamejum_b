using UnityEngine;

public class purasu : MonoBehaviour
{
    public static int nonderiti = 20;
    int TotalNonderi;
    public void OnClick()
    {
        TotalNonderi += nonderiti;

        if (TotalNonderi >= 100) TotalNonderi = 100;

        Debug.Log(TotalNonderi);
    }
}
