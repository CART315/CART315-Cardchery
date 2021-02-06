using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTarget : MonoBehaviour
{

    public GameObject Target;
    float spawnTimer;
    float spawnCurrentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(20, 300);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        spawnCurrentTime++;
        if (spawnCurrentTime >= spawnTimer)
        {
            GameObject.Instantiate(Target, this.transform.position, Quaternion.identity);
            Debug.Log("spawn");
            spawnCurrentTime = 0.0f;
            spawnTimer = Random.Range(300, 700);
        }
    }
}
