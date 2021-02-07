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
            GameObject newCard = Instantiate(cardProjectile, cardPositionInHand, Quaternion.Euler(2.307f, -18.854f, 6.724f));
            newCard.transform.SetParent(player.transform);
            cardHave = true;
        }

    }
}
