using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponentInChildren<SecondaryTrigger>().ExpectCollider(other);
    }
}
