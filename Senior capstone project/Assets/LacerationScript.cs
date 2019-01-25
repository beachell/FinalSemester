using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacerationScript : MonoBehaviour {

    //works but needs to be timed better. you want to have continuous pressure on the wound for
     public GameObject cut;

    int countdown = 50;


    void OnCollisionEnter(){
       StartCoroutine(CountingDown());
    }

    void OnCollisionExit(){
        StopCoroutine(CountingDown());
    }

    IEnumerator CountingDown(){
        Debug.Log("cut is compressed" +countdown);
        while(true)
        {
            if (countdown > 0)
            {
                countdown --;
                }
                else
                {
                cut.SetActive(false);
                StopCoroutine(CountingDown());
                }
         yield return new WaitForSeconds(1);

        }

    }

}
