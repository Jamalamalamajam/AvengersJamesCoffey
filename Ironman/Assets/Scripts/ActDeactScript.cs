using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActDeactScript : MonoBehaviour {




	// Use this for initialization
	void Start () {
		StartCoroutine(Wait());
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	IEnumerator Wait(){
		
		yield return new WaitForSeconds (20.0f);
		SceneManager.LoadScene (1);
	}
		
}