using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.InputSystem; // 新しい入力システム

public class TextChanger : MonoBehaviour
{
    // ★ここに手動で作ったUIテキストをドラッグ＆ドロップします
    [SerializeField] private TextMeshProUGUI textMeshPro;

    // ★表示したい日本語の文章（ここで自由に書き換えてOK！）
    private string[] sentences = new string[]
    {
        "むかしむかし、あるところに...",
        "おじいさんとおばあさんがいました。",
        "めでたしめでたし！"
    };

    private int currentIndex = 0;
    private bool isChanging = false;

    void Start()
    {
        // 最初の文章を表示
        if (textMeshPro != null && sentences.Length > 0)
        {
            textMeshPro.text = sentences[currentIndex];
        }
    }

    void Update()
    {
        // マウスクリック・画面タップを検知
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame && !isChanging)
        {
            StartCoroutine(ChangeTextRoutine());
        }
    }

    IEnumerator ChangeTextRoutine()
    {
        isChanging = true;

        textMeshPro.text = ""; // 一度消す
        yield return new WaitForSeconds(0.5f); // 0.5秒待つ

        currentIndex = (currentIndex + 1) % sentences.Length;
        textMeshPro.text = sentences[currentIndex];

        isChanging = false;
    }
}