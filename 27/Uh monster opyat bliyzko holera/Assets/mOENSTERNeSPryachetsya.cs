using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mOENSTERNeSPryachetsya : MonoBehaviour {

	// Use this for initialization
	public Transform moenster;
	void Start () {
		
	
	
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(moenster.position, transform.position);	
		print (dist);
	
	
	
	}
}
