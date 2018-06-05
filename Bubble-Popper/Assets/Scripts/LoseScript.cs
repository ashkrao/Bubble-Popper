using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{

    Text loseMessage;
    AudioSource loseSound;

    // Use this for initialization
    void Start()
    {
        loseMessage = GetComponent<Text>();
        loseSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (TimerScript.timeLeft == 0 || ScoreScript.Missed == 15)
        {
           // Destroy(bubbleSpawner);
            loseMessage.text = "You Lose!";
            Destroy(BubbleSpawner.bubblespawner);
            loseSound.GetComponent<AudioSource>().enabled = true;
            TimerScript.timer.enabled = false;
            ScoreScript.score.enabled = false;
            ScoreScript.missed.enabled = false;
        }
    }
}
