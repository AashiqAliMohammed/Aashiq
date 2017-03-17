using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

private Vector3 inputvalue;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		inputvalue.x = CrossPlatformInputManager.GetAxis("Horizontal");
		inputvalue.y = 0f;
		inputvalue.z = CrossPlatformInputManager.GetAxis("Vertical");

		transform.Translate(inputvalue);
	}
}
