using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRepositionScript : MonoBehaviour {

	public Transform StartPoint;
	public Transform EndPoint;
	
	Vector3 reference;
	
	public int loopCount;
	
	void Start ()
	{
		RenderSettings.ambientLight = new Color(0.1f, 0.1f, 0.1f);
	}

	void Update ()
	{
		Debug.Log ("Loop Count = " + loopCount);
		
		if (Input.GetButtonDown ("Jump")) {
			loopCount++;
		}
		ChangeLighting();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			reference = other.transform.position - StartPoint.position;
			other.transform.position = EndPoint.position + reference;
			loopCount += 1;
			ChangeLighting();
		}
	}
	
	void ChangeLighting ()
	{
		/*if (loopCount == 2) {
			RenderSettings.ambientLight = new Color(0.5f, 0.5f, 0.5f);
		}
		if (loopCount == 3) {
			RenderSettings.ambientLight = Color.grey;
		}
		if (loopCount == 6) {
			RenderSettings.ambientLight = Color.red;
		}
		else {
			RenderSettings.ambientLight = new Color(0.2f, 0.2f, 0.2f);
		}*/
		
		if (loopCount < 10) {
			RenderSettings.ambientLight = new Color ((loopCount / 10), (loopCount / 10), (loopCount / 10));
			Debug.Log ("Ambient colour = " + (loopCount/10));
		}
		if (loopCount >= 10) {
			RenderSettings.ambientLight = Color.black;
		}
		
	}
}
