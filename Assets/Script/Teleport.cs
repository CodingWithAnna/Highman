using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform Destination;       // Gameobject where they will be teleported to


	// Use this for initialization
	void Start () {
		// As needed
	}

	// Update is called once per frame
	void Update () {
		// As needed
	}

	void OnTriggerEnter(Collider hit) {

		if (hit.gameObject.name == "cube (6)") {
			GameObject.Find ("Player").SendMessage ("React");
		}
	}

	void React () {
			transform.position = new Vector3(0, 2, 0);
		}
}