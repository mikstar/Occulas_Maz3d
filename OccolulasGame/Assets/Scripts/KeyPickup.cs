using UnityEngine;
using System.Collections;

public class KeyPickup : InteractiveObjects {


	protected override void effect()
	{
		GameObject.FindWithTag(TagsStatics.playerTag).GetComponent<Keyholder>().addKey(gameObject);
		turnOnOff(false);
		GetComponent<AudioSource>().Play();
	}

	public void turnOnOff(bool OnOff)
	{
		collider.enabled = OnOff;
		renderer.enabled = OnOff;

		transform.GetChild(0).gameObject.SetActive(OnOff);
		transform.GetChild(1).gameObject.SetActive(OnOff);
		transform.GetComponent<KeyRotate>().stopTurn();
	}
}
