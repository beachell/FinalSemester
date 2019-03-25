using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpenCap : MonoBehaviour
{
    float followDistance = 12;

    public GameObject Epen;
    public GameObject objectToActivate;
   
    public GameObject objectToDeactvate;
    public GameObject objectToDeactvate2;





    void OnMouseDrag(){
        Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, followDistance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    void OnTriggerExit(Collider col)
    {
        if (Epen.CompareTag("Epen"))
        {
            Epen.SetActive(false);
            objectToActivate.SetActive(true);
            objectToDeactvate2.SetActive(false);
            objectToDeactvate.SetActive(false);
        }
    }
}