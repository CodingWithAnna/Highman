using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parenting: MonoBehaviour {

	public Transform platform;
	public Transform player;
	
	void OnTriggerEnter( Collider col ){
		if (col.tag == "Player") {

			col.transform.parent = platform.transform;    
		}
	}

		void OnTriggerExit(Collider col)
		{
			if(col.tag == "Player")
		{
		col.transform.parent = null;                
		}
	}
}
//	public void OnTriggerEnter(Collider collider){
//
//		if(collider.gameObject.tag == "platform"){
//			transform.parent = collider.transform;
//
//		}
//	}
//
//	public void OnTriggerExit(Collider collider){
//		if(collider.gameObject.tag == "platform"){
//			transform.parent = null;
//		}
//	}

