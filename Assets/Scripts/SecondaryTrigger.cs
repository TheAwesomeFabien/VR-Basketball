using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour
{
    private Collider expectedCollider;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == expectedCollider)
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(1);
        }
    }
}
