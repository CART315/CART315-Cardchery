using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwCard : MonoBehaviour
{
    public GameObject cardLocation;
    public GameObject cardProjectile;
    public GameObject player;
    public Vector3 cardSpin = new Vector3(0, 20, 0);
    bool thrown = false;
    Vector3 throwingForce = new Vector3(0, 0, 700f);
    // Start is called before the first frame update
    void Start()
    {
        thrown = false;
        transform.rotation = Quaternion.Euler(2.307f, -18.854f, 6.724f);
        GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if the card is in the hand, it is not thrown. It is placed in the hand, if it is thrown, leaves the hand and spins until it hits something
        if (thrown == true)
        {
            GetComponent<Transform>().Rotate(cardSpin);
            
        }
        else
        {
            // go to the hand area
            Vector3 cardPositionInHand = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
           // Debug.Log("hand" + cardPositionInHand);
           // Debug.Log("current" + transform.position);
          //  transform.position = cardPositionInHand;
            // if click, throw it and spawn another card in the hand
            if (Input.GetMouseButtonDown(0) && thrown == false)
            {
                thrown = true;
                this.GetComponent<Rigidbody>().AddForce(throwingForce);
                GetComponent<Rigidbody>().useGravity = true;
                transform.parent = null;
                makeCard.cardHave = false;
            }
        }
    }
}
