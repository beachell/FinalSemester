using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscript : MonoBehaviour {

 
    bool flickering  = true;
    public float shortTime = 0.0f;
    public float longwait = 0.5f;
    public float intesLight = 1;
    public float randIntes;
void Start() {
    StartCoroutine(flickerLight());
        
}
 
IEnumerator flickerLight() {
 
    while(flickering) {
        randIntes = Random.Range(1, intesLight + 1);
        float waittime = Random.Range(shortTime, longwait+1);

     yield return new WaitForSeconds(waittime);
        gameObject.GetComponent<Light>().intensity += randIntes;
        yield return new WaitForSeconds(waittime);
        gameObject.GetComponent<Light>().intensity = 0;
    }
}
}
