using UnityEngine;
using System.Collections;

public class ButtonBase : MonoBehaviour {

	public Light lightsource;
	public AudioClip sound;

	void OnMouseEnter()
	{
		lightsource.enabled = true;
	}
	void OnMouseExit()
	{
		lightsource.enabled = false;
	}

	void OnMouseDown()
	{
		clickEffect();
		GetComponent<AudioSource>().PlayOneShot(sound);

	}

	public virtual void clickEffect()
	{

	}
}
