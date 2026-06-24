using UnityEngine;
using UnityEngine.UI;

public class result_script : MonoBehaviour
{
    public Image image;
    public Sprite result;//診断証

    private Image img;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = image.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.sprite = result;
    }
}
