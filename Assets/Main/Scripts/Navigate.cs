using UnityEngine;
using System.Collections;

public class Navigate : MonoBehaviour
{
	bool isJumping = false;
	int jumpSpeed = 15;
	int numBumps = 0;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
print ("update");
		if ( isJumping )
		{
			print ("jumping");
			transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
			if ( ++numBumps > 50 ) isJumping = false;
		}
		else if ( Input.GetButtonDown( "Jump" ) )
		{
			print ("jump!");
			isJumping = true;
			numBumps = 0;
		}
	}
}
