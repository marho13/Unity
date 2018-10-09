using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingMotion : MonoBehaviour {
    public float FLeftSpeed = 0f;
    public float FRightSpeed = 0f;
    public float BLeftSpeed = 0f;
    public float BRightSpeed = 0f;
    public Transform FRRot;
    public Transform FLRot;
    public Transform BRRot;
    public Transform BLRot;
	
	// Update is called once per frame
	void Update () {
		//Check the rotation of each blade, and give a force in the upward direction (if the rotation is 45* the force is created so that the drone continues in that direction)
	}
}
