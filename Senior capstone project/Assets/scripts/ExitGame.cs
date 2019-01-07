using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 StartCoroutine(EndGame());
	}
	
	IEnumerator EndGame(){
	    while(true){
            if (Input.GetKeyDown(KeyCode.Escape)){
                Debug.Log("exited");
                Application.Quit();
                }
              yield return new WaitForSeconds(1);
	     }
	}
}
