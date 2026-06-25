using UnityEngine;
using TMPro;

public class A_ResultUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // 1回目のスコアを保存（まだ保存されていない場合だけ）
        A_DataKeep.Instance.SaveFirstScoreIfNeeded();

        // 1回目のスコアを表示
        scoreText.text = A_DataKeep.Instance.FirstScore.ToString();
    }
}