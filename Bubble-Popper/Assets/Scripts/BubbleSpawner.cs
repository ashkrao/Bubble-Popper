using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{

    public Bubble bubblePrefab;
    private float bubbleSpawnTimer;
    public static BubbleSpawner bubblespawner;
    void Start()
    {
        Physics.gravity = new Vector3(0f, -0.02f, 0f);
        bubblespawner = GetComponent<BubbleSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        const float BubbleSpawnTime = 1f;
        bubbleSpawnTimer += Time.deltaTime;
        if (bubbleSpawnTimer >= BubbleSpawnTime)
        {
            bubbleSpawnTimer = 0;

            //Spawn bubble near the camera and above the ground 
            Vector3 cameraPosition = Camera.main.gameObject.transform.position;

            Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            randomDirection.Normalize();

            float randomDistance = Random.Range(1f, 4f);
            randomDirection *= randomDistance;

            Vector3 randomPosition = cameraPosition + randomDirection;

            //Ensure that bubbles spawn above the floor
            randomPosition.y = Mathf.Max(0.0f, randomPosition.y);

            //Spawn bubble
            Bubble bubble = Instantiate<Bubble>(bubblePrefab, randomPosition, Random.rotation);

            const float forceMagnitude = 0.25f;
            bubble.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-forceMagnitude, forceMagnitude), Random.Range(0f, forceMagnitude), Random.Range(-forceMagnitude, forceMagnitude)));

            const float torqueMagnitude = 0.25f;
            bubble.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-torqueMagnitude, torqueMagnitude), Random.Range(-torqueMagnitude, torqueMagnitude), Random.Range(-torqueMagnitude, torqueMagnitude)));

        }

    }
}
