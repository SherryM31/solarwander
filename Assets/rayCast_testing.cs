using UnityEngine;
using System.Collections;

public class rayCast_testing : MonoBehaviour {



	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		float theDistance;
		float range = 500f;
	
		//forward = object's forward direction with the speed of 8
		Vector3 forward = transform.TransformDirection(Vector3.forward)*20;

		//Draw a raycast line from camera's position to forward direction in green color
		Ray landingRay = new Ray (transform.position, forward);
		Debug.DrawRay (transform.position, forward, Color.green);

		//if raycast collides any object at a distance of 500, all animations are stopped
		if (Physics.Raycast (landingRay, out hit, range)) {
			theDistance = hit.distance;
			Debug.Log (theDistance + " " + hit.collider.gameObject.name);
			GameObject.Find ("CenterOfGravity_mercury").GetComponent<CenterOfGravity_Mercury> ().enabled = false;
			GameObject.Find ("CenterOfGravity_venus").GetComponent<Venus_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_earth").GetComponent<Earth_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_mars").GetComponent<Mars_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_jupiter").GetComponent<Jupiter_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_saturn").GetComponent<Saturn_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_titan").GetComponent<Titan_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_uranus").GetComponent<Uranus_CenterOfGravity> ().enabled = false;
			GameObject.Find ("CenterOfGravity_neptune").GetComponent<Neptune_CenterOfGravity> ().enabled = false;
		} else {
			GameObject.Find ("CenterOfGravity_mercury").GetComponent<CenterOfGravity_Mercury> ().enabled = true;
			GameObject.Find ("CenterOfGravity_venus").GetComponent<Venus_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_earth").GetComponent<Earth_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_mars").GetComponent<Mars_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_jupiter").GetComponent<Jupiter_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_saturn").GetComponent<Saturn_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_titan").GetComponent<Titan_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_uranus").GetComponent<Uranus_CenterOfGravity> ().enabled = true;
			GameObject.Find ("CenterOfGravity_neptune").GetComponent<Neptune_CenterOfGravity> ().enabled = true;
		}
	}
}
