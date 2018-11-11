using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	float originalY;


	public float floatStrength = 1;             //Can be changed in inspector





	void Start()
	{
		this.originalY = this.transform.position.y;  //Create reference to variable and assign it


	}

	void FixedUpdate()
	{
		transform.position = new Vector3(transform.position.x,            
			originalY + ((float)Mathf.Sin(Time.time) * floatStrength),        
			transform.position.z);                                         //Function is called every frame to move the platform
	}





}