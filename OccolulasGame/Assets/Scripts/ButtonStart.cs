using UnityEngine;
using System.Collections;

public class ButtonStart : ButtonBase {

	public int sceneNumber;

	public override void clickEffect()
	{
		Application.LoadLevel(sceneNumber);
	}
}
