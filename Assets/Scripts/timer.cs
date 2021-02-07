using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float timeLeft = 60.0f;
    public static float timeLeftShown = 60;
    public Text timeLeftText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft + 1 <= timeLeftShown)
        {
            timeLeftShown--;
        }
        if (timeLeft <= 0)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
        timeLeftText.text = "Time Left: " + timeLeftShown;
    }
}
