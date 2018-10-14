using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneForce : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float _frontRightSpeed, _frontLeftSpeed, _backRightSpeed, _backLeftSpeed;

    Vector3 _frontRightRotor, _frontLeftRotor, _backLeftRotor, _backRightRotor;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        _frontRightRotor = new Vector3(-1.4f, 0.4f, 0.8f);
        _frontLeftRotor = new Vector3(-1.4f, 0.4f, -0.8f);
        _backRightRotor = new Vector3(1.4f, 0.4f, 0.8f);
        _backLeftRotor = new Vector3(1.4f, 0.4f, -0.8f);
    }

    void Update()
    {
        AddForceToRotor(_frontRightSpeed, (transform.rotation * _frontRightRotor) + transform.position);
        AddForceToRotor(_frontLeftSpeed, (transform.rotation * _frontLeftRotor) + transform.position);
        AddForceToRotor(_backRightSpeed, (transform.rotation * _backRightRotor) + transform.position);
        AddForceToRotor(_backLeftSpeed, (transform.rotation * _backLeftRotor) + transform.position);
    }

    private void AddForceToRotor(float speed, Vector3 rotor)
    {
        rb.AddForceAtPosition(speed * transform.up * Time.deltaTime, rotor);
    }
}
