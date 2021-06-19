using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour
{
    [SerializeField] private int scorePerHit = 1;

    private void OnCollisionEnter(Collision other)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scorePerHit);
    }
}
