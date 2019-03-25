using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour {
    public GameObject thisObject;
    public GameObject Arties;
    public AudioClip audio;
    AudioSource audiosource;
    private int count = 0;


    void Start(){
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = audio;

    }

    void OnMouseOver()
    {
     count ++;
     if (count < 1)
         {
            Arties.SetActive(true);
            print("beat");
            audiosource.Play();
            StartCoroutine(WaitForSound(audio));

         }
    }

    void OnMouseExit()
    {
        StopCoroutine(WaitForSound(audio));
        Arties.SetActive(false);
        count = 0;
    }

    public IEnumerator WaitForSound(AudioClip Sound)
    {
        yield return new WaitUntil(() => audiosource.isPlaying == false);

        if(Arties != null)
        {
        //this is when you stop the script and activate the next text line and deactivate this object
        thisObject.SetActive(false);
        }
    }
    //https://gamedev.stackexchange.com/questions/134002/how-can-i-do-something-after-an-audio-has-finished
}
