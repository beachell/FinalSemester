using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneActivate : MonoBehaviour
{
    public GameObject objectToActivate;

    void Start()
    {

    }

    void OnMouseDown()
    {
        objectToActivate.SetActive(true);
        this.gameObject.SetActive(false);

    }
}
