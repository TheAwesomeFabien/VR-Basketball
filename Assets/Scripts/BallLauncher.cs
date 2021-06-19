using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballSpeed = 5f;
    [SerializeField] private Transform rightHand;
    private bool ballInHand = false;

    private GameObject tempBall;
    // Update is called once per frame
    void Update()
    {
        if (!ballInHand)
        {
            print("spawn");
            ballInHand = !ballInHand;
            tempBall = Instantiate(ballPrefab);
            tempBall.GetComponent<Rigidbody>().useGravity = false;
            tempBall.transform.position = rightHand.position;
        }

        if (Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") > 0.2f)
        {
            print("launch");
            //tempBall.transform.parent = null;
            tempBall.GetComponent<Rigidbody>().useGravity = true;
            tempBall.GetComponent<Rigidbody>().velocity = rightHand.rotation * Vector3.forward * ballSpeed;
            ballInHand = !ballInHand;
        }
    }
}
