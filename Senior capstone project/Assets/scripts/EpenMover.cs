using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpenMover : MonoBehaviour {

    float followDistance = 12;

    public GameObject Epen;
    public GameObject objectToActivate;


    void OnMouseDrag(){
	    Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, followDistance);
	    Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
	    transform.position = objPosition;
	}

    void OnTriggerEnter(Collider col)
    {
	    if (Epen.CompareTag("Epen"))
	    {
		    Epen.SetActive(false);
		    objectToActivate.SetActive(true);
	    }
    }
}
