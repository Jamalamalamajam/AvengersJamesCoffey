using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalSceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider ChangeScene) // can be Collider HardDick if you want.. I'm not judging you
	{
		if(ChangeScene.gameObject.CompareTag("Finish"))
		{
			Application.LoadLevel(2); //1 is the build order it could be 1065 for you if you have that many scenes
		}
	}
}
