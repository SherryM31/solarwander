using UnityEngine;
using System.Collections;

public class rayCast_testing : MonoBehaviour {



	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		float theDistance;
		//public float range = 200f;
	
		Vector3 forward = transform.TransformDirection(Vector3.forward)*8;
		Debug.DrawRay (transform.position, forward, Color.green);

		if (Physics.Raycast (transform.position,(forward), out hit)) {
			theDistance = hit.distance;
			Debug.Log (theDistance + " " + hit.collider.gameObject.name);
		}
	}
}
