using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        // transform.rotation = Quaternion.Euler(0,90,0) * (Quaternion.Euler(0,30,0));
    }

    // Update is called once per frame
    void Update()
    {
        ControlCamera();
    }

    void ControlCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0,mouseX,0) * transform.localRotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mouseY,0,0) * camera.transform.localRotation;
    }
}
