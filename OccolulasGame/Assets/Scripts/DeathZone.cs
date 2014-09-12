using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == TagsStatics.playerTag)
		{
			col.gameObject.GetComponent<PlayerDeathRespawn>().killPlayer();
		}
	}
}
