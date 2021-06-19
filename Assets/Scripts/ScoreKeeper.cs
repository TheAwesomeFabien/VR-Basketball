using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int score;

    public void IncrementScore(int addScore)
    {
        score += addScore;
        print("You scored. Your current score is " + score);
    }
    
    public int GetScore()
    {
        return score;
    }
}
