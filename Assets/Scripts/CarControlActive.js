var CarControl : GameObject;
var DreamCar1 : GameObject;

function Start () {
	CarControl.GetComponent("CarController").enabled = true;
	DreamCar1.GetComponent("CarAIControl").enabled = true;
}