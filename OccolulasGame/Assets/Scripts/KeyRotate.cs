using UnityEngine;
using System.Collections;

public class KeyRotate : MonoBehaviour {

	private float speed = 30;


	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}

	public void stopTurn(){
		speed = 0;
	}
}
