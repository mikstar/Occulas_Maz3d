using UnityEngine;
using System.Collections;

public class PlayerDeathRespawn : MonoBehaviour {

	public Transform respawnPoint;
	public float respawnTime;
	

	public void newSpawnPoint(Transform pos)
	{
		respawnPoint = pos;
	}

	private void respawn()
	{
		transform.position = respawnPoint.position;
	}

	public void killPlayer()
	{
		Debug.Log("Dead!");
		GetComponent<Keyholder>().resetAllKeys();
		StartCoroutine(deathDelay());
	}

	private IEnumerator deathDelay()
	{
		yield return new WaitForSeconds(respawnTime);
		respawn();
	}
}
