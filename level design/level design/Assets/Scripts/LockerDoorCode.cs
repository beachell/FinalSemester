using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoorCode : MonoBehaviour {

	public GameObject objectToActivate;

    private void Start()
    {
        objectToActivate.SetActive(false);
    }

    void OnMouseDown()
	{
		objectToActivate.SetActive(true); 
		this.gameObject.SetActive(false);
		
	}
}
//this is to trigger the door activator objects to proceed