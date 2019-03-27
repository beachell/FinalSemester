using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpenCap : MonoBehaviour
{
    float followDistance = 12;

    public GameObject Epencap;
    public GameObject EpenToActivate;
   
    public GameObject objectToDeactvate;

    private void OnEnable()
    {
        objectToDeactvate.SetActive(true);
    }


    void OnMouseDrag(){
        Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, followDistance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    void OnTriggerExit(Collider col)
    {
            Epencap.SetActive(false);
            objectToDeactvate.SetActive(false);
            EpenToActivate.SetActive(true);
    }
}