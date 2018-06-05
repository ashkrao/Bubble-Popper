using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{

    Text winMessage;
    AudioSource winSound;
   // BubbleSpawner bubbleSpawner;

    // Use this for initialization
    void Start()
    {
        winMessage = GetComponent<Text>();
        winSound = GetComponent<AudioSource>();
       // bubbleSpawner = GetComponent<BubbleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.ScoreValue == 5)
        {
            winMessage.text = "You Win!";
            Destroy(BubbleSpawner.bubblespawner);
            winSound.GetComponent<AudioSource>().enabled = true;
            TimerScript.timer.enabled = false;
            ScoreScript.score.enabled = false;
            ScoreScript.missed.enabled = false;
        }
    }
}
