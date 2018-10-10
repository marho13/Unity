using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {

    public Rigidbody rb;

    public Vector3 Front;
    public Vector3 Back;
    public Vector3 Left;
    public Vector3 Right;

    public GameObject chopper;
    public GameObject frontTrans;
    public GameObject backTrans;

    public Vector3 FrontForce;
    public Vector3 BackForce;
    public Vector3 LeftForce;
    public Vector3 RightForce;

    public Vector3 dirForce;

    public int upForce = 700;
    public int force = 10;
    public int distance = 2;

    void Start()
    {

        //transform.position - chopper.transform.position;
        Front = frontTrans.transform.position - transform.position;
        Back = backTrans.transform.position - transform.position;
        //Back.Set(0, 0, -distance);
        Left.Set(distance, 0, 0);
        Right.Set(distance, 0, 0);

        FrontForce.Set(0, force * Time.deltaTime, 0);
        BackForce.Set(0, force * Time.deltaTime, 0);
        LeftForce.Set(0, force * Time.deltaTime, 0);
        RightForce.Set(0, force * Time.deltaTime, 0);
        Debug.Log("I fucked jakobs mom ('''\\_(o.O)_/''')"); //forceFr = force * Time.deltaTime, 0, 0;
    }


    void FixedUpdate () {
        dirForce.Set(0, force * Time.deltaTime, 0);
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForceAtPosition(Front.normalized, dirForce);
            //rb.AddForce(force * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            //rb.AddForce(-force * Time.deltaTime, 0, 0);
            rb.AddForceAtPosition(Back.normalized, dirForce);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime);
            //rb.AddForceAtPosition(Left, LeftForce);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime);
            //rb.AddForceAtPosition(Right, RightForce);
        }

    }
}
