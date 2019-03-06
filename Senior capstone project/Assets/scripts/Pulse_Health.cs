using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse_Health : MonoBehaviour {
   // public bool heartBeating = true;
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
    //public GameObject Epen;





    void Start () {
      index   = Random.Range(bpm, heartAttack + 1);

    //  StartCoroutine(HeartBeat(index));
      StartCoroutine(Breathing());

      TheCprObject.SetActive(false);
      DeathObject.SetActive(false);
     // Epen.SetActive(true);
    }


    IEnumerator Breathing() {
      //int stopbreathing = 20;
        while (isBreathing)
        {
             
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
                print("injection" + isBreathing);
                StartCoroutine(Breathing());
            }
            else
            {
                index = index + badInjection;
            }        
    }





}
