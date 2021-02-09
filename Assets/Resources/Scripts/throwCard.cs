using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwCard : MonoBehaviour
{
    public GameObject cardLocation;
    public GameObject cardProjectile;
    public Vector3 cardSpin = new Vector3(0, 8, 0);
    bool thrown = false;
    int damage = 1;
    int speed = 30;

    Vector3 throwDirection;
    // Start is called before the first frame update
    void Start()
    {
        thrown = false;
        this.gameObject.tag = "card";
        transform.rotation = Quaternion.Euler(2.307f, -18.854f, 6.724f);
        GetComponent<Rigidbody>().useGravity = false;
    }

    // when this hits a target, that target loses health equal to this card's damage
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target")
        {
            collision.gameObject.GetComponent<targetCode>().takeDamage(damage);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject player = GameObject.Find("PlayerCamera");
        // if the card is in the hand, it is not thrown. It is placed in the hand, if it is thrown, leaves the hand and spins until it hits something
        if (thrown == true)
        {
            GetComponent<Transform>().Rotate(cardSpin);

            transform.position += throwDirection * speed * Time.deltaTime;
            
        }
        else
        {
            // go to the hand area
            Vector3 cardPositionInHand = new Vector3(cardLocation.transform.position.x, cardLocation.transform.position.y, cardLocation.transform.position.z);
           // Debug.Log("hand" + cardPositionInHand);
           // Debug.Log("current" + transform.position);
          //  transform.position = cardPositionInHand;
            // if click, throw it and spawn another card in the hand
            if (Input.GetMouseButtonDown(0) && thrown == false)
            {
                thrown = true;
                GetComponent<Rigidbody>().useGravity = true;
                transform.parent = null;
                makeCard.cardHave = false;
                throwDirection = player.transform.forward;
                // find how much damage this would deal based on the card chosen
                damage = gameManager.cardEffects[gameManager.cardSlots[gameManager.cardChosen]];
                // randomly choose another card to replace that slot
                gameManager.cardSlots[gameManager.cardChosen] = Random.Range(0, 2);
            }
        }
    }
}
