/* Broc Edson
 * Challenge 1
 * Manages the score and game endings conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameEnded;
    public static bool won;

    public Text textbox;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameEnded = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameEnded)
        {
            textbox.text = "Score: " + score;
            if (score >= 5)
            {
                gameEnded = true;
                won = true;
            }
            else if (player.transform.position.y > 80 || player.transform.position.y < -51)
            {
                gameEnded = true;
            }
        }
        else
        {
            string endText = "";
            if(won)
            {
                endText += "You Win!";
            }
            else
            {
                endText += "Game Over! You went out of bounds!";
            }
            endText += "\nPress R to Restart";
            textbox.text = endText;
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
