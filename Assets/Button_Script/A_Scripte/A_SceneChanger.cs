using UnityEngine;
using UnityEngine.SceneManagement;

public class A_SceneChanger : MonoBehaviour
{
    //== 定数 ==

    //リザルト判定用
    const int OKSCORE = 0;
    const int LITTLEBADSCORE = 50;
    const int BADSCORE = 100;

    //シーン名
    const string OKSCENE = "Result _nonderi";
    const string LITTLEBADSCENE = "Result _nonderi _yobi";
    const string BADSCENE = "Result _notnonderi 1";

    public void OnMyButtonClick(string nextSceneName)
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定
    }

    public void ResultSceneChange()
    {
        int resultScore = A_DataKeep.Instance.TotalNonderi;
        if (resultScore == OKSCORE)
        {
            SceneManager.LoadScene(OKSCENE); // シーン名で指定
        }
        else if (resultScore <= LITTLEBADSCORE)
        {
            SceneManager.LoadScene(LITTLEBADSCENE); // シーン名で指定
        }
        else if(resultScore <= BADSCORE) 
        {
            SceneManager.LoadScene(BADSCENE); // シーン名で指定
        }
    }

}
