using UnityEngine;
using UnityEngine.UI;

public class bakemono : MonoBehaviour
{
    public GameObject monster;
    public GameObject nonderi;
    public GameObject button1;
    public GameObject button2;
    public float settime;
    public float settime2;
    public float buck;
    public float buttontime;
    float time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        monster.SetActive(false);
        nonderi.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > settime) {
        monster.SetActive (true);
        }

        if (time > settime2)
        {
         monster.SetActive (false);
        }

        if(time > buck)
        {
            nonderi.SetActive (true);
        }

        if(time > buttontime)
        {
            button1.SetActive (true);
            button2.SetActive (true);
        }
    }
}
