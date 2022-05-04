using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar1Track : MonoBehaviour {

	public GameObject TheMarker;
	public GameObject Mark1;
	public GameObject Mark2;
	public GameObject Mark3;
	public GameObject Mark4;
	public GameObject Mark5;
	public GameObject Mark6;
	public int MarkTracker;

	void Update () {
		if (MarkTracker == 0) {
			TheMarker.transform.position = Mark1.transform.position;
		}
		if (MarkTracker == 1) {
			TheMarker.transform.position = Mark2.transform.position;
		}
		if (MarkTracker == 2) {
			TheMarker.transform.position = Mark3.transform.position;
		}
		if (MarkTracker == 3) {
			TheMarker.transform.position = Mark4.transform.position;
		}
		if (MarkTracker == 4) {
			TheMarker.transform.position = Mark5.transform.position;
		}
		if (MarkTracker == 5) {
			TheMarker.transform.position = Mark6.transform.position;
		}

	}

	IEnumerator OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "DreamCar1") {
			this.GetComponent<BoxCollider> ().enabled = false;
			MarkTracker += 1;
			if (MarkTracker == 6) {
				MarkTracker = 0;
			}
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}
}
