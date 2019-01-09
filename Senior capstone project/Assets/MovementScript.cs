using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

	public int moveSpeed = 1;

	private Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		StartCoroutine(Mover());
	}

	
	IEnumerator Mover() {
		while (true)
		{
			print("la la");
			float HorzMove = Input.GetAxis("Horizontal");
			float vertMove = Input.GetAxis("Vertical");
			Vector3 movement = new Vector3(HorzMove, 0.0f, vertMove);

			rb.AddForce(movement * moveSpeed);
		}

		yield return new WaitForSeconds(1);
		

	}


}
