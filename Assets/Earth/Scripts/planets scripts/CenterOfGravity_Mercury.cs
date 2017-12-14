using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfGravity_Mercury : MonoBehaviour {

	float rotationSpeed = 8.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
	}
}
