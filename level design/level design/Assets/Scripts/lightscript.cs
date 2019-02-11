﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscript : MonoBehaviour {

 
bool flickering  = true;
    public float shortTime = 0.0f;
public float longwait = 0.5f;
    
void Start() {
    StartCoroutine(flickerLight());
}
 
IEnumerator flickerLight() {
 
    while(flickering) {
     float waittime = Random.Range(shortTime, longwait+1);

     yield return new WaitForSeconds(waittime);
        gameObject.GetComponent<Light>().intensity += 5;
        yield return new WaitForSeconds(waittime);
        gameObject.GetComponent<Light>().intensity = 0;
    }
}
}