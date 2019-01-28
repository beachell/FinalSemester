using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacerationScript : MonoBehaviour {


    //works but needs to be timed better. you want to have continuous pressure on the wound for
     public GameObject cut;

    int countdown = 50;

    void OnMouseOver(){
        Debug.Log("cut is compressed" +countdown);
        if (countdown > 0){
        countdown --;
        print(countdown);
        }else {
        cut.SetActive(false);
        }
    }

}
