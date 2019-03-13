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
            objectToActivate.SetActive(false);
        }
        print("end");
    }
}
