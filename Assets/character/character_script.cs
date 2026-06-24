using UnityEngine;
using UnityEngine.UI;

public class character_script : MonoBehaviour
{
    public Image image;
    public Sprite chara1;  //下4行差分用
    public Sprite chara2;
    public Sprite chara3;
    public Sprite chara4;

    private Image character1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        character1 = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        character1.sprite = chara1;
    }
}
