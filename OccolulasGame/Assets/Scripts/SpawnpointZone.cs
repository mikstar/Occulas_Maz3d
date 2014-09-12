using UnityEngine;
using System.Collections;

public class SpawnpointZone : MonoBehaviour {

	public Light spawnLight;
	public Transform trueSpawn;

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == TagsStatics.playerTag && col.gameObject.GetComponent<PlayerDeathRespawn>().respawnPoint != trueSpawn)
		{
			col.gameObject.GetComponent<PlayerDeathRespawn>().newSpawnPoint(trueSpawn);
			spawnLight.enabled = true;
			GetComponent<AudioSource>().Play();
		}
	}
}
