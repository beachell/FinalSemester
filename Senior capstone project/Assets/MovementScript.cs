using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

	public int moveSpeed = 1;

	private Rigidbody rb;

	public float waitTime = 0.1f;
	
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		StartCoroutine(Mover());
	}


	/*private void FixedUpdate()
	{*/
		
	IEnumerator Mover() {
		while (true)
		{

			float HorzMove = Input.GetAxis("Horizontal");
			float vertMove = Input.GetAxis("Vertical");
			Vector3 movement = new Vector3(HorzMove, 0.0f, vertMove);

			rb.AddForce(movement * moveSpeed);
			yield return new WaitForSeconds(waitTime);

		}

		

	}


}
