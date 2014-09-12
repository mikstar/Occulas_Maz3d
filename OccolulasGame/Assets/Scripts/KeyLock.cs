using UnityEngine;
using System.Collections;

public class KeyLock : InteractiveObjects {

	private bool hasKey = false;
	private float turnPerFrame;
	private int turnFor;
	private EndDoor doorScript;

	public Transform receivePoint;
	
	void Start()
	{
		turnPerFrame = transform.eulerAngles.z/110;
		doorScript = transform.parent.gameObject.GetComponent<EndDoor>();
		doorScript.addLock();
	}

	void Update()
	{
		if(turnFor > 0)
		{
			Vector3 tempAngle = transform.eulerAngles;
			tempAngle.z = tempAngle.z - turnPerFrame;
			transform.eulerAngles = tempAngle;
			turnFor --;
		}
	}

	protected override void effect()
	{
		if(!hasKey)
		{
			GameObject key = GameObject.FindWithTag(TagsStatics.playerTag).GetComponent<Keyholder>().takeOuKey();

			if(key != null)
			{
				turnFor = 110;
				hasKey = true;
				key.GetComponent<KeyPickup>().turnOnOff(true);
				key.transform.position = receivePoint.position;
				key.transform.parent = transform;
				doorScript.removeLock();
				GetComponent<AudioSource>().Play();

			
			}
			else{
				//Debug.Log("No key");
			}
		}
	}
}
