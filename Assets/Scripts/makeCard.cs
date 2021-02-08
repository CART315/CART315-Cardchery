using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCard : MonoBehaviour
{
    public GameObject player;
    public GameObject cardProjectile;
    public static bool cardHave = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cardHave == false)
        {
            Vector3 cardPositionInHand = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            Vector3 cardRotationInHand = new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
            GameObject newCard = Instantiate(cardProjectile, cardPositionInHand, Quaternion.Euler(cardRotationInHand));
            GameObject player = GameObject.Find("PlayerCamera");
         //   newCard.transform.position = player.transform.position + player.transform.forward;
        //    newCard.transform.forward = player.transform.forward;
            newCard.transform.SetParent(player.transform);
            newCard.tag = "card";
            cardHave = true;
        }

    }
}
