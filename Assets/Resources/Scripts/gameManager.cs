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
    public Text cardSlotOne;
    public Text cardSlotTwo;
    public Text cardSlotThree;
    public Text cardSlotFour;
    public Text cardSlotFive;
    // make the sprite variables and the array of the cards
    // Sprite Card1Damage;
    // Sprite Card2Damage;
    // Sprite Card3Damage;
    // which screen we are on (menu, game, end)
    public static int gameScreens = 0;
    // public static Sprite[] cardSprites = new Sprite[3];
    public static int[] cardEffects = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        // add the images and effects of each card type into the arrays
        // Card1Damage = Resources.Load<Sprite>("Images/card1");
        // Card2Damage = Resources.Load<Sprite>("Images/card2");
        // Card3Damage = Resources.Load<Sprite>("Images/card3");
        // sprites for 1, 2 and 3 damage
        // cardSprites[0] = Card1Damage;
        // cardSprites[1] = Card2Damage;
        // cardSprites[2] = Card3Damage;
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
            // set the number of each card in the card slots UI
            cardSlotOne.text = cardEffects[cardSlots[0]].ToString();
            cardSlotTwo.text = cardEffects[cardSlots[1]].ToString();
            cardSlotThree.text = cardEffects[cardSlots[2]].ToString();
            cardSlotFour.text = cardEffects[cardSlots[3]].ToString();
            cardSlotFive.text = cardEffects[cardSlots[4]].ToString();
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
