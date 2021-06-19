using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    private float velocity = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input .GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject tijdelijk = Instantiate(ballPrefab);
            Rigidbody rb = tijdelijk.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * velocity;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject tijdelijk = Instantiate(ballPrefab);
            Rigidbody rb = tijdelijk.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * velocity;
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject tijdelijk = Instantiate(ballPrefab);
            Rigidbody rb = tijdelijk.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * velocity;
        }
    }
}
