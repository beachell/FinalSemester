using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFall : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		//GetComponent<Rigidbody>().useGravity = true;
		if (col.gameObject.tag == "Player")
		{
			gameObject.SetActive(false);
			print("collided");
		}
		
	}

	
}
