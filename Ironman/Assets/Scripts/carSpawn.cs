using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour {

	//public GameObject spawner;

	//public GameObject car1;

	public GameObject prefab1, prefab2, prefab3, prefab4;

	public float spawnRate = 2; // Time.time + Random.Range(1f,4f);

	float nextSpawn = 0f;

	int whatToSpawn;

	void Start(){

	}
		

	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			whatToSpawn = Random.Range (1, 5);
			//Debug.Log (whatToSpawn);

			switch (whatToSpawn) {
			case 1:
				Instantiate (prefab1, transform.position, transform.rotation);
				break;
			case 2:
				Instantiate (prefab2, transform.position, transform.rotation);
				break;
			case 3:
				Instantiate (prefab3, transform.position, transform.rotation);
				break;
			case 4:
				Instantiate (prefab4, transform.position, transform.rotation);
				break;
			}

			nextSpawn = Time.time + spawnRate;





		}
	}
}

//Instantiate (car1, transform.position, transform.rotation);
