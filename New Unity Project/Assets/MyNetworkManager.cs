using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

private NetworkManager networkmanager;
	
	public void MyStartHost()
	{
	Debug.Log( + Time.timeSinceLevelLoad + " - Starting host " );
	StartHost();
	}
	public override void OnStartHost ()
	{
		Debug.Log( + Time.timeSinceLevelLoad + "- host Started ");
	}
	public override void OnStartClient (NetworkClient myClient)
	{
		Debug.Log( + Time.timeSinceLevelLoad + " -Client Start Requested" );
		InvokeRepeating ("PrintDots",0f,1f);
	}
	public override void OnClientConnect (NetworkConnection conn)
	{
	Debug.Log (+Time.timeSinceLevelLoad + "Client is connected to IP:" + conn.address);
	CancelInvoke ();
	}
	void PrintDots ()
	{
	Debug.Log(".");
	}
}
