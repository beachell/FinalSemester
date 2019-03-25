using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookScript : MonoBehaviour {


	//found this script, not mine
	public float mouseSensitivity = 100.0f;
	public float clampAngle = 80.0f;
 
	private float rotY = 0.0f; // rotation around the up/y axis
	private float rotX = 0.0f; // rotation around the right/x axis
	private float waitTime = .0001f;
 
	void Start ()
	{
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
		StartCoroutine(Looker());
	}
 
	IEnumerator Looker() {
	while (true)
		{
		    if(Input.GetKeyDown(KeyCode.Space)){
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = -Input.GetAxis("Mouse Y");

                rotY += mouseX * mouseSensitivity * Time.deltaTime;
                rotX += mouseY * mouseSensitivity * Time.deltaTime;

                rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

                Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
                transform.rotation = localRotation;
             }
          yield return new WaitForSeconds(waitTime);
		}
	}
}
	/*
    public float LookRadius = 90.0f;
    float rotY = 0.0f;
    float rotX = 0.0f;

    void Start(){
        StartCoroutine(Rotator());
    }

    IEnumerator Rotator(){
        while(true){
        if(Input.GetButtonPressed("Mouse X"))
        yield return new WaitForSeconds(waitTime);
        }
    }

}*/
