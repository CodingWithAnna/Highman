﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeCol : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
//			SceneManager.LoadScene ("Level2");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
