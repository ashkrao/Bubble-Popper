using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public static float timeLeft;
    public static Text timer;
    // Use this for initialization
    void Start()
    {
        timer = GetComponent<Text>();
        timeLeft = 120;
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
            float minutes = Mathf.Floor(timeLeft / 60);
            float seconds = Mathf.Floor(timeLeft % 60);
            timer.text = "Timer: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        } 
    }
}
