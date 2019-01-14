using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour {


    public bool isBreathing = true;
    public bool alive = true;
    bool exhale = true;

    int stopbreathing = 20;
    public float badInjection = 3;
    private float index = 0;

    public GameObject TheCprObject;
    public GameObject DeathObject;
    public GameObject Epen;


    void Start () {
       index   = Random.Range(1, stopbreathing + 1);
      StartCoroutine(BreathingF(index));

      TheCprObject.SetActive(false);
      DeathObject.SetActive(false);
      Epen.SetActive(true);
    }

    IEnumerator BreathingF(float breath) {

        while (isBreathing)
        {
            //this will run every second randomly testing the value to see if it should stop breathing.

            if (breath < stopbreathing)
                {
              // Debug.Log("breathing" + index);
                }else{
                isBreathing = false;
                DeathObject.SetActive(true);
                StopCoroutine(BreathingF(index));
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
             index   = Random.Range(1, stopbreathing + 1);
                isBreathing = true;
                exhale = true;
                DeathObject.SetActive(false);
                print("injection" + isBreathing);
                StartCoroutine(BreathingF(index));
                TheCprObject.SetActive(true);
            }
            else
            {
                index = index + badInjection;
            }
    }





}