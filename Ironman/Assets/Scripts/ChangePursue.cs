using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePursue : MonoBehaviour {

	public MonoBehaviour behaviourToEnable;
	public MonoBehaviour behaviourToDisable;


	//public Pursue pursueScript;
	//public Seek seekScript;

	// Use this for initialization
	void Start () {
		//pursueScript = GetComponent<Pursue> ();
		//seekScript = GetComponent<Seek> ();
		StartCoroutine(Wait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Wait(){

		yield return new WaitForSeconds (80.0f);

		behaviourToDisable.enabled = false;
		behaviourToEnable.enabled = true;



		//pursueScript.enabled = false;
		//seekScript.enabled = true;
	}
}
