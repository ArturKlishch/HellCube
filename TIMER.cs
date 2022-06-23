using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public float timestart;
    public Text timerText;
    void Start()
    {
        timerText.text = timestart.ToString("F3");
    }

    void Update()
    {

            timestart += Time.deltaTime;
            timerText.text = timestart.ToString("F3");
      
    }
}
