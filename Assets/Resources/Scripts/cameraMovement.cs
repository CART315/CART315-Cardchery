using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // public Transform player;
    float speedH = 3.0f;
    float speedV = 3.0f;
    float yaw = 0.0f;
    float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        yaw = Mathf.Clamp(yaw, -60f, 60f);
        pitch = Mathf.Clamp(pitch, -50f, 30f);

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        // https://www.youtube.com/watch?v=lYIRm4QEqro
    }
}
