using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneMove : MonoBehaviour {

    public Rigidbody rb;

    public int directionalforce = 5;
    public int upForce = 350;
    public int constantF = 350;

    public float rotationX;
    public float rotationY;
    public float rotationZ;


    void FixedUpdate()
    {
        rb.AddForce(0, constantF * Time.deltaTime, 0);
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            moveForward();
            
        }

        if (Input.GetKey("s"))
        {
            moveBackward();
        }

        if (Input.GetKey("a"))
        {
            moveLeft();
        }

        if (Input.GetKey("d"))
        {
            moveRight();
        }

    }

    public void moveForward()
    {
        rb.AddRelativeForce(Vector3.forward * directionalforce);
        rotationX = 0;
        rotationY = 0;
        rotationZ = 1;
    }

    public void moveBackward()
    {
        rb.AddRelativeForce(Vector3.back * directionalforce);
        rotationX = 0;
        rotationY = 0;
        rotationZ = 1;
    }

    public void moveLeft()
    {
        rb.AddRelativeForce(Vector3.left * directionalforce);
        rotationX = -1;
        rotationY = 0;
        rotationZ = 0;
    }

    public void moveRight()
    {
        rb.AddRelativeForce(Vector3.right * directionalforce);
        rotationX = 1;
        rotationY = 0;
        rotationZ = 0;
    }
}
