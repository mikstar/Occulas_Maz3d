using UnityEngine;
using System.Collections;

public class StayRelativeTo : MonoBehaviour {

	public Transform followObj;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - followObj.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = followObj.position + offset;
	}
}
