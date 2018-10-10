using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneMove : MonoBehaviour
{

    public Rigidbody rb;

    public Vector3 rotationChange;

    public int directionalforce = 5;
    public int upForce = 350;
    public int constantF = 350;
    public int rotInt = 180;

    public float rotationX;
    public float rotationY;
    public float rotationZ;


    void FixedUpdate()
    {
        rotationCheck();
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


    //called each update, to rotate properly when letting go of controls
    public void rotationCheck()
    {
        if (rotationX > 90)
        {
            //rotate towards 180
        }
        else
        {
            //rotate towards 0
        }

        //check y
        if (rotationY > 90)
        {

        }
        else
        {

        }

        //check z
        if (rotationZ > 90)
        {

        }
        else
        {

        }
    }

    public void moveForward()
    {
        rb.AddRelativeForce(Vector3.left * directionalforce);
        rotationX = 0;
        rotationY = 0;
        rotationZ = rotInt;
        rotationChange.Set(rb.transform.rotation.x, rb.transform.rotation.y, rotationZ);
        Quaternion rot = Quaternion.Euler(rotationChange * Time.deltaTime);
        rb.MoveRotation(rot);
    }

    public void moveBackward()
    {
        rb.AddRelativeForce(Vector3.right * directionalforce);
        rotationX = 0;
        rotationY = 0;
        rotationZ = rotInt;
        rotationChange.Set(rb.transform.rotation.x, rb.transform.rotation.y, rotationZ);
        Quaternion rot = Quaternion.Euler(rotationChange * Time.deltaTime);
        rb.MoveRotation(rot);
    }

    public void moveLeft()
    {
        rb.AddRelativeForce(Vector3.back * directionalforce);
        rotationX = -rotInt;
        rotationY = 0;
        rotationZ = 0;
        rotationChange.Set(rotationX, rb.transform.rotation.y, rb.transform.rotation.z);
        Quaternion rot = Quaternion.Euler(rotationChange * Time.deltaTime);
        rb.MoveRotation(rot);
    }

    public void moveRight()
    {
        rb.AddRelativeForce(Vector3.forward * directionalforce);
        rotationX = rotInt;
        rotationY = 0;
        rotationZ = 0;
        rotationChange.Set(rotationX, rb.transform.rotation.y, rb.transform.rotation.z);
        Quaternion rot = Quaternion.Euler(rotationChange * Time.deltaTime);
        rb.MoveRotation(rot);

    }
}