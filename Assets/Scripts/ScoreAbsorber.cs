using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour
{
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = 1;
        if (oldKeeper)
        {
            score = oldKeeper.GetScore();
            Destroy(oldKeeper.gameObject);
        }

    }

    public int GetScore()
    {
        return score;
    }
}
