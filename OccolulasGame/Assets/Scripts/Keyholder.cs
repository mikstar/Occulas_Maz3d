using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Keyholder : MonoBehaviour {

	private List<GameObject> heldKeys = new List<GameObject>();

	//add a key to inventory
	public void addKey(GameObject key)
	{
		heldKeys.Add(key);
	}

	//Reset all keys currently in inventory, 
	//removing them from inventory and resetting them on the map
	public void resetAllKeys()
	{
		for(int i=0;i<heldKeys.Count;i++)
		{
			heldKeys[i].GetComponent<KeyPickup>().turnOnOff(true);
		}
		heldKeys = new List<GameObject>();
	}

	//remove a key from inventory and return it
	public GameObject takeOuKey()
	{
		//check if any keys are being held
		if(heldKeys.Count != 0)
		{
			int num = Mathf.FloorToInt(Random.Range(0,heldKeys.Count));
			GameObject retObj = heldKeys[num];
			heldKeys.RemoveAt(num);
			return retObj;	
		}
		return null;
	}
}
