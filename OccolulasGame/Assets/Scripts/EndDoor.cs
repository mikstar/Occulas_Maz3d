using UnityEngine;
using System.Collections;

public class EndDoor : MonoBehaviour {

	private int locksLeft;


	public void addLock()
	{
		locksLeft++;
	}

	public void removeLock()
	{
		locksLeft--;

		if(locksLeft == 0)
		{
			StartCoroutine(endDelay());
		}
	}

	IEnumerator endDelay()
	{
		yield return new WaitForSeconds(2.5f);
		Application.LoadLevel(Application.loadedLevel+1);
	}
}
