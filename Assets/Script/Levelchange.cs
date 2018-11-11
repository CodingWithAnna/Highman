using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //Heres what you need to add <----

public class Levelchange : MonoBehaviour {       

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (transform.position.y > 161) {   //if this charcater goes above y:161 change the scene

			changeScene ();                 //Call the Function to change scene

		}
	}

	void changeScene () {                   //Func that changes scene

		SceneManager.LoadScene (4);         //Load this scene when called, the 4 represents the scenes place in the index
		//For a main menu scene the number should be 1 since the main menu will be 0 in index
	}

}