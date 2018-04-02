using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchOnOff : MonoBehaviour {

	Light torchLight;
	
	void Start () {
		torchLight = GetComponent<Light>();
	}
	
	
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			LightSwitch();
		}
	}
	
	void LightSwitch ()
	{
		if (torchLight.intensity > 0) {
			torchLight.intensity = 0;
		}
		else {
			torchLight.intensity = 2;
		}
		
	}
}
