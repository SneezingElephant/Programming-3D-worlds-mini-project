using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    //Acess the score tally text box
    public TextMeshProUGUI scoreViz;

    
    public static int score;

   
    void Update()
    {
        DisplayScore();
        
    }

    private void DisplayScore()
    {

        
        //Display the score saved in score variable
        scoreViz.text = "Your total score is;" + " " + score.ToString() + " " + "!";

    }
}
