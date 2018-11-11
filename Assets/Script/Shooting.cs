using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject bullet_prefab;

	public float bulletImpulse = 100f;
	public float ballPosition = -1;
	public float ballRotation = -1;
	public int maxBalls = 3;
	int ballsCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && ballsCount <= maxBalls){

			//GameObject thebullet = (GameObject)Instantiate(bullet_prefab, transform.position, transform.rotation);
			GameObject thebullet = (GameObject)Instantiate(bullet_prefab, transform.position + new Vector3(0, ballPosition, 0), transform.rotation);
			ballsCount++;
		}
	}
}
