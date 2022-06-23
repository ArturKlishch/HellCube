using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeKomp : MonoBehaviour
{
    public GameObject display;
    public int hour;
    public int minute;
    public int sec;
    void Start()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        sec = System.DateTime.Now.Second;

        display.GetComponent<Text>().text = "Time is" + hour + ":" + minute + ":" + sec;
    }

    void Update()
    {
        Clock();
    }
    void Clock()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        sec = System.DateTime.Now.Second;

        display.GetComponent<Text>().text = "Time is" + hour + ":" + minute + ":" + sec;
    }
}
