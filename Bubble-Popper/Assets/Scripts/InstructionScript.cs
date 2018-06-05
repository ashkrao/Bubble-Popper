using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionScript : MonoBehaviour {

    Image instructions;
    // Use this for initialization
    void Start () {
        instructions = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update () {
        if (TimerScript.timeLeft == 110)
        {
            instructions.enabled = false ;
        }
    }
}
