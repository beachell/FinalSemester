using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

	public GameObject Crane;
	public GameObject audioObject;
	public GameObject EnableOtherDirection;

	public float YMove = 0;
	private float yMin = 0.7f;
	private float yMax = 4.0f;
	
	public float ZMove = 0;
	private float zMin = -4.5f;
	private float zMax = 16.0f;

	private void Start()
	{
		//GetComponent<Transform>(Crane).position;
		audioObject.SetActive(false);
	}

	// Use this for initialization
	private void OnMouseOver()
	{
		//if (gameObject.transform.localPosition )
		Crane.transform.Translate(0,YMove,ZMove);
		audioObject.SetActive(true);
		EnableOtherDirection.SetActive(false);
	}

	private void OnMouseExit()
	{
		audioObject.SetActive(false);
	}

	/*
	 * problem, crane goes too far left and right up and down.
	 *
	 * possible solutions,
	 * 1. have the buttons become gameobjects that can be triggered and will have a specific count with if statements
	 * to check if they can be used.
	 * 2. 
	 */

}
