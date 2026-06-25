using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
  //  public Button a;
    //public Button b;
   // public Button c;

    //[SerializeField] private string nextSceneName;
    //public void ChangeScene()
    //{
    //    SceneManager.LoadScene(nextSceneName); // シーン名で指定
    //}
    public void OnMyButtonClick(string nextSceneName)
    {
        SceneManager.LoadScene(nextSceneName); // シーン名で指定
    }
}