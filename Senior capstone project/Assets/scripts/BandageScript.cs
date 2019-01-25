using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandageScript : MonoBehaviour {

	float followDistance = 11;



    void OnMouseDrag(){
	    Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, followDistance);
	    Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

	    transform.position = objPosition;
	}

}
