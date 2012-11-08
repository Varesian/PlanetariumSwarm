using UnityEngine;
using System.Collections;

public class PointCloudCollideOnMouseOver : MonoBehaviour {

	void OnMouseOver() {
		Debug.Log ("MOUSE OVER!!!");
		//transform.renderer.material.color = Color.magenta;
		gameObject.SendMessage ("OnPointCloudCollisionEnter");
	}
	
	void OnMouseExit() {
		gameObject.SendMessage ("OnPointCloudCollisionExit");
	}
	
}
