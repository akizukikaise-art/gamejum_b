using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UI（テキスト）を使う場合

public class NonDeliManager : MonoBehaviour
{
    public static NonDeliManager Instance;

    // プレイヤーのノンデリ値（外部からこの数値を増減させる）
    public int nonDeliScore = 0;

    void Awake()
    {
        // シーンが変わってもこのオブジェクトを消さない（単体動作の肝）
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // シーンが切り替わったときに実行するイベントを登録
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // シーンが切り替わった瞬間に自動で呼ばれる処理
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 【重要】移動先のシーンに「ResultText」という名前のTextコンポーネントがあれば自動で見つけて反映
        GameObject resultObj = GameObject.Find("ResultText");
        if (resultObj != null)
        {
            Text textComponent = resultObj.GetComponent<Text>();
            if (textComponent != null)
            {
                textComponent.text = "あなたのノンデリ度: " + nonDeliScore + "%";
            }
        }
    }

    void OnDestroy()
    {
        // オブジェクトが削除されるときはイベントを解除（メモリリーク対策）
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}