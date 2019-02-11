using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class agonalBreathing : MonoBehaviour {

    public GameObject ObjectToBeActivated;
	public GameObject thisObject;
	//public GameObject Arties;
	public AudioClip audio;
	public AudioSource audiosource;
	// private int count = 0;
	void Start()
	{
		audiosource = GetComponent<AudioSource>();
		audiosource.clip = audio;
	}

	void OnEnable()
	{
		audiosource.Play();
		StartCoroutine(WaitForSound(audio));
	}

	/* this section is not needed. Will replace beat with agonal breathing sound to play when the object is activated
	 void OnMouseOver()
	   {
	    count ++;
	    if (count < 1)
	        {
	           Arties.SetActive(true);
	           print("beat"); 
	        }
	   } 
	   void OnMouseExit()
	   {
	       StopCoroutine(WaitForSound(audio));
	       Arties.SetActive(false);
	       count = 0;
	   }*/

	public IEnumerator WaitForSound(AudioClip sound)
	{
		print("the enum started");
		yield return new WaitUntil(() => audiosource.isPlaying == false);
		ObjectToBeActivated.SetActive(true);
		print("next lines ran");
		//if(Arties != null)
		//{
			//this is when you stop the script and activate the next text line and deactivate this object
			thisObject.SetActive(false);
		//}
	}

}
