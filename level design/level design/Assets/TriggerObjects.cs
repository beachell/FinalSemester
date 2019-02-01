using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour {
    public GameObject objectToDisappear;
    
    void Start()
    {
       
    }

    void OnMouseDown()
    {
        objectToDisappear.SetActive(false); 
    }
}
