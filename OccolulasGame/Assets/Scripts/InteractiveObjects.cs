using UnityEngine;
using System.Collections;

public class InteractiveObjects: MonoBehaviour {

	public void interact()
	{
		effect();
	}

	protected virtual void effect()
	{
		Debug.Log("effect");
	}
}
