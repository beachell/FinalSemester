using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneActivate : MonoBehaviour
{
    public GameObject objectToActivate;
    public bool activateButtonBla = true;

    void Start()
    {

    }

    void OnMouseDown()
    {
        //!= is the opposite of what it is
            
        objectToActivate.SetActive(!true);
    }
}
