using UnityEngine;
using System.Collections;

public class ButtonQuit : ButtonBase {

	public override void clickEffect()
	{
		Application.Quit();
	}
}
