using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopEffect : MonoBehaviour {

    private float destroyTimer;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroyTimer += Time.deltaTime;
        if (destroyTimer > 1f)
        {
           Destroy(this.gameObject);
        }
	}
}
