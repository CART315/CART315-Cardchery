using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // the chosen card out of the 5 slots
    public static int cardChosen = 0;
    // an array containing the content (what card) is in each of the 5 card slots. The number from 0 to 2
    // meaning either 1 damage, 2 damage or 3 damage
    public static int[] cardSlots = {0, 0, 0, 0, 0};
    // make the sprite variables and the array of the cards
    Sprite Card1Damage;
    Sprite Card2Damage;
    Sprite Card3Damage;
    public static Sprite[] cardSprites;
    public static int[] cardEffects;

    // Start is called before the first frame update
    void Start()
    {
        // add the images and effects of each card type into the arrays
        Card1Damage = Resources.Load<Sprite>("card1");
        Card2Damage = Resources.Load<Sprite>("card2");
        Card3Damage = Resources.Load<Sprite>("card3");
        Sprite[] cardSprites = { Card1Damage, Card2Damage, Card3Damage };
        int[] cardEffects = {1, 2, 3};
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if the button is pressed, choose that card in that slot
        if (Input.GetKeyDown("q"))
        {
            cardChosen = 0;
        }
        if (Input.GetKeyDown("w"))
        {
            cardChosen = 1;
        }
        if (Input.GetKeyDown("e"))
        {
            cardChosen = 2;
        }
        if (Input.GetKeyDown("r"))
        {
            cardChosen = 3;
        }
        if (Input.GetKeyDown("t"))
        {
            cardChosen = 4;
        }
    }

    // when the timer runs out, the game ends
    public void EndGame()
    {
        // restore the cursor from the screen
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadSceneAsync("End", LoadSceneMode.Single);
    }
}
