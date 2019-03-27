using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneActivate : MonoBehaviour
{
    public GameObject objectToActivate;    
    public bool onOff;

    void Start()
    {
        onOff = false;
        //objectToActivate.GetComponent<>()
    }

    void OnMouseDown()
    {
        print("start");
        onOff =! onOff;
        if (onOff == true)
        {
            objectToActivate.SetActive(true);           
            print("on");
        }
        else
        {
          /*  objectToActivate.GetComponent<Rigidbody>().isKinematic = false;
            objectToActivate.GetComponent<Rigidbody>().useGravity = true;
            objectToActivate.transform.DetachChildren();            */
            objectToActivate.SetActive(false);
            print("off");
        }
        print("end");
    }
}
