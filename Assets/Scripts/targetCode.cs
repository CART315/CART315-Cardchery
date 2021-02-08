using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetCode : MonoBehaviour
{

    int targetHealth;
    int targetMaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        // set the starting health
        targetMaxHealth = Random.Range(1, 4);
        targetHealth = targetMaxHealth;
        // this is a target
        gameObject.tag = "target";
        // set rotation
        this.transform.rotation = Quaternion.Euler(0, -90, 90);
        // make it pop up from below
        Vector3 spawnJump = new Vector3(0, 300, 0);
        this.GetComponent<Rigidbody>().AddForce(spawnJump);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "card")
        { 
            Destroy(collision.gameObject);
        }
    }

    public void takeDamage(int amount)
    {
        targetHealth -= amount;
        // if this dies, gain points
        if (targetHealth <= 0)
        {
            Destroy(this.gameObject);
            scoring.playerScore += targetMaxHealth * 5;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
