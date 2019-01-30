using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour {
    
    public GameObject Arties;
    

    void OnMouseOver()
    {
        Arties.SetActive(true);
        print("beat");
    }

    void OnMouseExit()
    {
        Arties.SetActive(false);       
    }   
}
