using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaflLapScipt : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	void OnTriggerEnter(){
		LapCompleteTrig.SetActive (true);
		HalfLapTrig.SetActive (false);
	}

}
