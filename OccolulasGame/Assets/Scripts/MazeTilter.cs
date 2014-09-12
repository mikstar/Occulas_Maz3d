using UnityEngine;
using System.Collections;

public class MazeTilter : MonoBehaviour {

	private GameObject maze;
	private bool turning;
	private float startTime;
	private int intDirect;
	private Vector3 turnAxis;

	public float turnTime;
	public Transform turnPoint;



	void Start()
	{
		maze = transform.GetChild(0).gameObject;
		transform.DetachChildren();
	}

	void FixedUpdate()
	{
		if(!turning)
		{
			if(Input.GetButtonDown("GiantX"))
			{
				turning = true;
				startRotate(new Vector3(90,0,0),Input.GetAxis("GiantX"));
			}
			else if(Input.GetButtonDown("GiantY"))
			{
				turning = true;
				startRotate(new Vector3(0,90,0),Input.GetAxis("GiantY"));
			}
			else if(Input.GetButtonDown("GiantZ"))
			{
				turning = true;
				startRotate(new Vector3(0,0,90),Input.GetAxis("GiantZ"));
			}
		}
		else
		{
			float timeLerp = (Time.time-startTime)/turnTime;
			if(timeLerp < 1)
			{
				transform.Rotate(((Vector3.Lerp(Vector3.zero,turnAxis,timeLerp))*intDirect)-transform.eulerAngles);
			}
			else
			{
				turning = false;
				transform.eulerAngles = turnAxis*intDirect;
				transform.DetachChildren();
				transform.Rotate(transform.rotation.eulerAngles*-1);
			}
		}
	}



	private void startRotate(Vector3 axis, float direct)
	{
		if(direct != 0)
		{
			GetComponent<AudioSource>().Play();
			turnAxis = axis;
			intDirect = (int)(direct/Mathf.Abs(direct));
			startTime = Time.time;
			transform.position = turnPoint.position;
			maze.transform.parent = transform;


		}
		else
		{
			turning = false;
		}
	}

}
