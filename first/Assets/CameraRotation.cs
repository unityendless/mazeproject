using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, -(speed * Time.deltaTime), 0);
        }
    }
}
