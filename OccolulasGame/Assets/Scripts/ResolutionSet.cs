using UnityEngine;
using System.Collections;

public class ResolutionSet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(3840, 1080, false);


		Application.targetFrameRate = 30;
		QualitySettings.vSyncCount = 0;
	}
}
