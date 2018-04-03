using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {

	PlayerRepositionScript loopCounter;
	Light thisLight;

	// Use this for initialization
	void Start () {
		loopCounter = GameObject.Find ("Reposition collider").GetComponent<PlayerRepositionScript>();
		
		thisLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		thisLight.intensity = 1.5f - ((loopCounter.loopCount * 2) / 10);
	}
}
