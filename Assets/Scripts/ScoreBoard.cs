using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour
{
    public Text scoreText;
    public Text levelText;
    public int score;
    private void Start()
    {
        levelText.text = "Level-1";
    }
   
    public void Increment(int value)
    {
        if(score==50)
        {
            levelText.text = "Level-2";
        }
        score += value;
        scoreText.text = "Score :" + score;
    }
}
