using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // destroy whatever it touches
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
