using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{

    public TextMeshProUGUI scoreViz;

    public static int score;

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
        
    }

    private void DisplayScore()
    {

        
        
        scoreViz.text = "Your total score is;" + " " + score.ToString() + " " + "!";

    }
}
