using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeManager : MonoBehaviour
{
    [SerializeField] private Image fadePanel; // 先ほど作ったFadePanelを割り当てる
    [SerializeField] private float fadeDuration = 2.0f; // 何秒かけて暗くするか

    void Start()
    {
        // テスト用：ゲーム開始と同時にだんだん暗くする
        StartFadeOut();
    }

    // 外部のボタンなどからこのメソッドを呼べば、好きなタイミングで暗転できます
    public void StartFadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeOutRoutine()
    {
        float elapsedTime = 0f;
        Color color = fadePanel.color;

        // 徐々に透明度（A）を 0 から 1 に近づける
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;

            // 経過時間に合わせてアルファ値を計算（0.0 ～ 1.0）
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            fadePanel.color = color;

            yield return null; // 1フレーム待つ
        }

        // 最後に確実に真っ黒（不透明）にする
        color.a = 1f;
        fadePanel.color = color;
    }
}