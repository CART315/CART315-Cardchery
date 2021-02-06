using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetCode : MonoBehaviour
{

    int targetHealth;

    // Start is called before the first frame update
    void Start()
    {
        // set the starting health
        targetHealth = Random.Range(1, 4);
        // set rotation
        this.transform.rotation = Quaternion.Euler(90, 0, 0);
        // make it pop up from below
        Vector3 spawnJump = new Vector3(0, 300, 0);
        this.GetComponent<Rigidbody>().AddForce(spawnJump);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Despawner")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
