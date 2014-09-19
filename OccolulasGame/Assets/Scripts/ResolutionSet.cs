using UnityEngine;
using System.Collections;

public class ResolutionSet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		/*Dk2*/// Screen.SetResolution(3840, 1080, false);
		/*Dk1*/ Screen.SetResolution(1280, 800, false);


		Application.targetFrameRate = 30;
		QualitySettings.vSyncCount = 0;
	}
}
