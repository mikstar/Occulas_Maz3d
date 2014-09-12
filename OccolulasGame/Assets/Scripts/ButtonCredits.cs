using UnityEngine;
using System.Collections;

public class ButtonCredits : ButtonBase {

	public Transform cam;
	public Vector3 targetPos;
	public Vector3 targetRotate;

	public override void clickEffect()
	{
		cam.position = targetPos;
		cam.eulerAngles = targetRotate;
	}
}
