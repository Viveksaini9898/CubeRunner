using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text score;
    int myScore = 0;
    public Text totalScore;
    public Text level;
    int initiallevel = 1;
    int total = 20;


    void Update()
    {
        score.text = myScore.ToString();
        totalScore.text = "Score : " + myScore.ToString();

        if(total == myScore)
        {
            level.text = "Level " + (initiallevel + 1);
            total = myScore + 20;
        }


    }

    private void Start()
    {
        level.text = "Level " + initiallevel;
    }

    public void addScore(int score)
    {
        myScore = myScore + score;
    }
}
