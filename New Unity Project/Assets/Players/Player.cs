using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

private Vector3 inputvalue;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLocalPlayer) {
		return;
		}
		inputvalue.x = CrossPlatformInputManager.GetAxis("Horizontal");
		inputvalue.y = 0f;
		inputvalue.z = CrossPlatformInputManager.GetAxis("Vertical");

		transform.Translate(inputvalue);
	}
	public override void OnStartLocalPlayer ()
	{
	GetComponentInChildren<Camera> ().enabled = true;
	}
}
