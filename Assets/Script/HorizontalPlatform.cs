using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : MonoBehaviour {

	float originalX;


	public float floatStrength = 1;             //Can be changed in inspector





	void Start()
	{
		this.originalX = this.transform.position.x;  //Create reference to variable and assign it


	}

	void FixedUpdate()
	{
		transform.position = new Vector3(transform.position.y,            
			originalX + ((float)Mathf.Sin(Time.time) * floatStrength),        
			transform.position.z);                                         //Function is called every frame to move the platform
	}





}