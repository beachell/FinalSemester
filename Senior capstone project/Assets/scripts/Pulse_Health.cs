using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse_Health : MonoBehaviour {
    public bool heartBeating = true;
    public bool isBreathing = true;
    public bool alive = true;
      bool exhale = true;


    public float elevatedBPM = 5;// rough value of 300 / 60
    public float bpm = 1;// the normal heart pulse is from 60bpm to 100bpm, caridac arrest happens around 400.// rough value of 60/60
    public float heartAttack = 6;//rough value of 400/60
    public float badInjection = 3;
    private float index = 0;

    public GameObject TheCprObject;
    public GameObject DeathObject;
    public GameObject Epen;





    void Start () {
      StartCoroutine(HeartBeat());
      StartCoroutine(Breathing());
      TheCprObject.SetActive(false);
      DeathObject.SetActive(false);
      Epen.SetActive(true);
    }

	//this is the running script that will check the heart beat
	IEnumerator HeartBeat() {
      
        while (heartBeating)
        {
            //make an if statement that will change the bpm and if it gets to heart attack it will trigger CardiacArrest() 
            //will need a function that will randomize if the patients heart beat increases to elevated and stay there and then randomly will increase or decrease unless treatment is done. 
            index   = Random.Range(bpm, heartAttack + 1);
            if (index < heartAttack)
                {
                //Debug.Log("beat_" +bpm);
                }else{
                heartBeating = false;
                Debug.Log("heart attack");
                TheCprObject.SetActive(true);
                }
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator Breathing() {
      int stopbreathing = 20;
        while (isBreathing)
        {
            //this will run every second randomly testing the value to see if it should stop breathing.
            index   = Random.Range(1, stopbreathing + 1);
            if (index < stopbreathing)
                {
              // Debug.Log("breathing" + index);
                }else{
                isBreathing = false;
                DeathObject.SetActive(true);
                StopCoroutine(Breathing());
                //Debug.Log("stopped breathing");
                }
            if(exhale == true){
               transform.localScale += new Vector3(0.1F, 0, 0);
               exhale = false;              
            } else {
               transform.localScale -= new Vector3(0.1F, 0, 0);
               exhale = true;
            }
         yield return new WaitForSeconds(1);
        }

    }

    void OnTriggerEnter (Collider col){
        
            if (isBreathing == false)
            {
                isBreathing = true;
                exhale = true;
                DeathObject.SetActive(false);
                print("injection" + isBreathing);
                StartCoroutine(Breathing());
            }
            else
            {
                index = index + badInjection;
            }        
    }





}
