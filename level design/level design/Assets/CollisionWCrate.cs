using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWCrate : MonoBehaviour
{
    GameObject parent;
    public GameObject SoundObject;
    public GameObject stopMovingdown;
    
    // Start is called before the first frame update
    void Start()
    {
        SoundObject.SetActive(false);        
    }

    private void OnCollisionEnter(Collision other)
    {
        other.transform.SetParent(this.transform);
        print("collided");
        SoundObject.SetActive(true);
        stopMovingdown.SetActive(true);
     //   other.transform.GetComponent<Rigidbody>().isKinematic = true;
       // other.transform.GetComponent<Rigidbody>().useGravity = false;
        
    }

    private void OnDisable()
    {
        this.transform.DetachChildren();
    }
}
//this script is to grab onto the crate when it collides with the object this script is on.