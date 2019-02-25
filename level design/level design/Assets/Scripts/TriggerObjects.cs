using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour {
    public GameObject objectToActivate;

    public float moveDirectionx;
    public float moveDirectiony;
    public float moveDirectionz;
    
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        float startPos = transform.position;
    }

    void OnMouseDown()
    {
        //objectToDeactivate.SetActive(false); 
        //this.gameObject.SetActive(false);
        //rend.material.shader = Shader.Find("_Color");
        //rend.material.SetColor = ("_Color.red");
        objectToActivate.transform.position = Mathf.Lerp(moveDirectionx,moveDirectiony,moveDirectionz);
    }
}
