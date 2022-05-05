using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {

	public static int CarType;
	public GameObject TrackWindown;

	public void RedCar () {
		CarType = 1;
		TrackWindown.SetActive (true);
	}

	public void BlueCar () {
		CarType = 2;
		TrackWindown.SetActive (true);
	}
}
