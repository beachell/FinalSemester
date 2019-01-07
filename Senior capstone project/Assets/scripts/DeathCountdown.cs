using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCountdown : MonoBehaviour {

int countdown = 120;

  void OnEnable() {
        StartCoroutine(Death());
    }
	IEnumerator Death() {
	while (true){
	     countdown--;
	    if (countdown==0){

            print("gameOver");
	        }
	    yield return new WaitForSeconds(1);
	    }
	 }

}
