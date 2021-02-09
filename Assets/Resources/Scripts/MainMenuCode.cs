using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        // reset all variables then start the game
        timer.timeLeft = 60;
        timer.timeLeftShown = 60;
        scoring.playerScore = 0;
        // randomise 5 starting cards
        for (int i = 0; i < 5; i++)
        {
            int cardTemp = Random.Range(0, 2);
            gameManager.cardSlots.Add(cardTemp);
        }
        // remove the cursor from the screen
        gameManager.gameScreens = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadSceneAsync("Game", LoadSceneMode.Single);
    }
}
