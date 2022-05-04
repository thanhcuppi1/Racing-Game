using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

	public GameObject NormalCam;
	public GameObject FPCam;
	public int CamMode;

	void Update () {
		if (Input.GetButtonDown ("Viewmode")) {
			if (CamMode == 1) {
				CamMode = 0;
			} else {
				CamMode += 1;
			}
			StartCoroutine (ModeChange ());
		}
	}

	IEnumerator ModeChange () {
		yield return new WaitForSeconds (0.01f);
		if (CamMode == 0) {
			NormalCam.SetActive (true);
			FPCam.SetActive (false);
		}
		if (CamMode == 1) {
			FPCam.SetActive (true);
			NormalCam.SetActive (false);
		}


	}
}