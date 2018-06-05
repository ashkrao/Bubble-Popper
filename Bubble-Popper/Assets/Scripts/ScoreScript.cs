using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int ScoreValue = 0;
    public static int Missed = 0;
    public static Text score;
    public static Text missed;
    void Start()
    {
        score = GetComponent<Text>();
        missed = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Pop score: " + ScoreValue + "\n" + "Missed: " + Missed;
    }
}
