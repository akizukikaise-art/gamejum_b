using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class A_DataKeep : MonoBehaviour
{
    //データの保存に必要
    public static A_DataKeep Instance;

    public int FirstScore = -1;//1回目のスコア
    public int TotalNonderi = 0;//今回のスコア

    [SerializeField] private TextMeshProUGUI scoreText;

    //シーンを移動してもデータを保存するコード
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            // シーンが変わったら UI を探し直す
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //リザルトシーンにだけ ScoreText がある前提
        //リザルトシーンだけにスコア表示
        scoreText = GameObject.Find("ScoreText")?.GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
    }


    //トータルに加算、表示
    public void AddNonderiti(int amount)
    {
        TotalNonderi += amount;
        if (TotalNonderi >= 100) TotalNonderi = 100;
        Debug.Log(TotalNonderi);
    }

    //画面にトータルスコアを表示
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = TotalNonderi.ToString();
        }
    }

    // リザルト画面に来た時に呼ぶ
    public void SaveFirstScoreIfNeeded()
    {
        if (FirstScore == -1)   // まだ保存されていない時だけ
        {
            FirstScore = TotalNonderi;
        }
    }
    //public void RestartGame()
    //{
    //    // 今回のスコアを前回スコアとして保存
    //    DataKeep.Instance.LastScore = DataKeep.Instance.TotalNonderi;

    //    // 今回のスコアをリセット
    //    DataKeep.Instance.TotalNonderi = 0;

    //    // ゲームシーンを読み込み
    //    SceneManager.LoadScene("GameScene");
    //}
    //void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    scoreText = GameObject.Find("ScoreText")?.GetComponent<TextMeshProUGUI>();

    //    if (scoreText != null)
    //    {
    //        scoreText.text = DataKeep.Instance.LastScore.ToString();
    //    }
    //}
}