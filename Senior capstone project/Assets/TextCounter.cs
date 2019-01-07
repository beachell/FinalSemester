using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCounter : MonoBehaviour
{
	public int countdown = 3;
	public GameObject ConverstationUi; 
	
	// Use this for initialization
	void TextCountdownFun () {

		if (countdown == 0)
		{
			//deactivate the text here
			ConverstationUi.SetActive(false);
			
		}
	}
	

}
