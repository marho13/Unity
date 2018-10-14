using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneMove : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject fR;
    public GameObject fL;
    public GameObject bR;
    public GameObject bL;

    public Vector3 rotationChange;
    public Vector3 force;
    public Vector3 dirForce;

    public int directionalforce = 50;
    public int upForce = 350;
    public int constantF = 350;
    public int rotInt = 10;

    public float rotationX;
    public float rotationY;
    public float rotationZ;
    public float maxSpeed;
    public float wantedX;
    public float currentX;

    private void Start()
    {
        force.Set(0, constantF * Time.deltaTime, 0);
        dirForce.Set(0, directionalforce * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        Debug.Log(rb.transform.rotation);
        rb.AddForce(0, constantF * Time.deltaTime, 0);
        if (Input.GetKey("space"))
        {
            rb.AddForceAtPosition(force, fR.transform.position); //this force should be based on the angle, meaning 45* = 0.7 in that direction
            rb.AddForceAtPosition(force, fL.transform.position);
            rb.AddForceAtPosition(force, bR.transform.position);
            rb.AddForceAtPosition(force, bL.transform.position);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(-upForce * Time.deltaTime, 0, 0);
            rb.AddForceAtPosition(dirForce, bR.transform.position);
            rb.AddForceAtPosition(dirForce, bL.transform.position);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(upForce * Time.deltaTime, 0, 0);
            rb.AddForceAtPosition(dirForce, fR.transform.position);
            rb.AddForceAtPosition(dirForce, fL.transform.position);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -upForce * Time.deltaTime);
            rb.AddForceAtPosition(dirForce, fR.transform.position);
            rb.AddForceAtPosition(dirForce, bR.transform.position);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, upForce * Time.deltaTime);
            rb.AddForceAtPosition(dirForce, fL.transform.position);
            rb.AddForceAtPosition(dirForce, bL.transform.position);
        }

    }

    public void sinCalc()
    {
        //float X = Mathf.Sin(rb.transform.rotation.z)//rotation is probably in angles not radians while mathf needs radians
        //this should use the angle to find how much it should go in X, Y and Z directions
    }

}