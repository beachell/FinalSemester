using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjects : MonoBehaviour {
    public GameObject objectToActivate;
    public GameObject soundObject;
    public Animator anim;
    public bool openSaysMe;
  //  int open = Animator.StringToHash("Open");

    void Start()
    {
          anim = objectToActivate.GetComponent<Animator>();
          openSaysMe = false;
          soundObject.SetActive(false);

    }

    void OnMouseDown()
    {
        openSaysMe = true;   
        anim.SetBool("Open", openSaysMe);
        this.gameObject.SetActive(false);
        soundObject.SetActive(true);

    }
}
//this is used as the door opener
