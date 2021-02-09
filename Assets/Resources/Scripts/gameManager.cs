using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // the chosen card out of the 5 slots
    public static int cardChosen = 0;
    // an array containing the content (what card) is in each of the 5 card slots. The number from 0 to 2
    // meaning either 1 damage, 2 damage or 3 damage
    public static List<int> cardSlots = new List<int>();
    // reference the card slots UI
    public Sprite cardSlotOne;
    public Sprite cardSlotTwo;
    public Sprite cardSlotThree;
    public Sprite cardSlotFour;
    public Sprite cardSlotFive;
    // make the sprite variables and the array of the cards
    Sprite Card1Damage;
    Sprite Card2Damage;
    Sprite Card3Damage;
    // which screen we are on (menu, game, end)
    public static int gameScreens = 0;
    public static Sprite[] cardSprites = new Sprite[3];
    public static int[] cardEffects = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        gameScreens = 0;
        // add the images and effects of each card type into the arrays
        Card1Damage = Resources.Load<Sprite>("Images/card1");
        Card2Damage = Resources.Load<Sprite>("Images/card2");
        Card3Damage = Resources.Load<Sprite>("Images/card3");
        // sprites for 1, 2 and 3 damage
        cardSprites[0] = Card1Damage;
        cardSprites[1] = Card2Damage;
        cardSprites[2] = Card3Damage;
        Debug.Log("1");
        // 1, 2 and 3 damage to be passed into card damage variable
        cardEffects[0] = 1;
        cardEffects[1] = 2;
        cardEffects[2] = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // cursor lock based on screen
        if (gameScreens == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            // set the images of each card in the card slots UI
            cardSlotOne = cardSprites[cardSlots[0]];
            cardSlotTwo = cardSprites[cardSlots[1]];
            cardSlotThree = cardSprites[cardSlots[2]];
            cardSlotFour = cardSprites[cardSlots[3]];
            cardSlotFive = cardSprites[cardSlots[4]];
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
        if (gameScreens == 0 || gameScreens == 2)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // when the timer runs out, the game ends
    public void EndGame()
    {
        // restore the cursor from the screen
        gameScreens = 2;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadSceneAsync("End", LoadSceneMode.Single);
    }
}
