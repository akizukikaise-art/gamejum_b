using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeManager : MonoBehaviour
{
    [SerializeField] private Image fadePanel; // FadePanelを割り当てる
    [SerializeField] private float fadeDuration = 2.0f; // 何秒かけて暗く/明るくするか

    void Start()
    {
        // テスト用：ゲーム開始と同時にだんだん暗くし、終わったらだんだん明るくする
        StartCoroutine(TestSequence());
    }

    // テスト用のシーケンス（暗くなった後に明るくする）
    private IEnumerator TestSequence()
    {
        yield return StartCoroutine(FadeOutRoutine()); // 暗くなるのを待つ
        yield return new WaitForSeconds(1.0f);        // 1秒真っ黒な状態を維持
        yield return StartCoroutine(FadeInRoutine());  // 明るくなるのを待つ
    }

    // 外部から呼ぶためのメソッド（暗転用）
    public void StartFadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    // 外部から呼ぶためのメソッド（明転用）★追加
    public void StartFadeIn()
    {
        StartCoroutine(FadeInRoutine());
    }

    // だんだん暗くする（アルファ値を 0 → 1 にする）
    private IEnumerator FadeOutRoutine()
    {
        float elapsedTime = 0f;
        Color color = fadePanel.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            // 0.0 から 1.0 へ変化
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            fadePanel.color = color;
            yield return null;
        }

        color.a = 1f;
        fadePanel.color = color;
    }

    // だんだん明るくする（アルファ値を 1 → 0 にする）★追加
    private IEnumerator FadeInRoutine()
    {
        float elapsedTime = 0f;
        Color color = fadePanel.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            // ★ポイント：1.0 から経過時間割合を引くことで、1.0 → 0.0 へ減少させる
            color.a = Mathf.Clamp01(1.0f - (elapsedTime / fadeDuration));
            fadePanel.color = color;
            yield return null;
        }

        // 最後に確実に透明（アルファ値 0）にする
        color.a = 0f;
        fadePanel.color = color;
    }
}