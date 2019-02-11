using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoorCode : MonoBehaviour {

	public GameObject objectToDeactivate;
    
	void Start()
	{
       
	}

	void OnMouseDown()
	{
		objectToDeactivate.SetActive(false); 
		this.gameObject.SetActive(false);
	}
}
