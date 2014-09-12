using UnityEngine;
using System.Collections;

public class ObjectInteract : MonoBehaviour {

	// Vars


	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			Ray ray = new Ray(transform.position, fwd);


			if(Physics.Raycast(ray, out hit, 2))
			{
				if(hit.collider.gameObject.tag == "IntObj")
				{
					hit.collider.gameObject.GetComponent<InteractiveObjects>().interact();
				}
			}
		}
	}
}
