using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour {
    public GameObject objectToActivate;
    public Animator anim;
    public bool openSaysMe;
  //  int open = Animator.StringToHash("Open");

    void Start()
    {
          anim = objectToActivate.GetComponent<Animator>();
          openSaysMe = false;
    }

    void OnMouseDown()
    {
        openSaysMe = true;        
        this.gameObject.SetActive(false);

    }
}
