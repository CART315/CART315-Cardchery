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
        spawnTimer = Random.Range(40, 800);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        spawnCurrentTime++;
        if (spawnCurrentTime >= spawnTimer)
        {
           // Vector3 cardPositionInHand = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            GameObject newTarget = Instantiate(Target, this.transform.position, Quaternion.identity);
            spawnCurrentTime = 0.0f;
            spawnTimer = Random.Range(300, 800);
        }
    }
}
