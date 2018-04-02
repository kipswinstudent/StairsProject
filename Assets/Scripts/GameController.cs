using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	PlayerRepositionScript loopCounter;

	void Start () {
		loopCounter = GameObject.Find("Reposition collider").GetComponent<PlayerRepositionScript>();
	}
	
	
}
