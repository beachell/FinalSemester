using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

	public GameObject Crane;

	public float YMove = 0;
	private float yMin = 0.7f;
	private float yMax = 4.0f;
	
	public float ZMove = 0;
	private float zMin = -4.5f;
	private float zMax = 16.0f;

	private void Start()
	{
		//GetComponent<Transform>(Crane).position;
	}

	// Use this for initialization
	private void OnMouseOver()
	{
		//if (gameObject.transform.localPosition )
		Crane.transform.Translate(0,YMove,ZMove);
	}

	

}
