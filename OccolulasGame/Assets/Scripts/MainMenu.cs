using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit))
			{
				if(hit.transform.name == "PlayButton")
				{
					Application.LoadLevel(1);
				}
				if(hit.transform.name == "OptionsButton")
				{
					Debug.Log("Play now");
				}
				if(hit.transform.name == "ExitButton")
				{
					Application.Quit();
				}
			}
		}
	}
}
