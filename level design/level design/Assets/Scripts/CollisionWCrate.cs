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
        //put an if statement to check the tag of the crate to run this code.
        //have an else statement so it will stopMovingdown.SetActive(true); for anything else
        if (other.gameObject.tag == "crate")
        {
            print("collided crate");
            other.transform.SetParent(this.transform);
            SoundObject.SetActive(true);
            stopMovingdown.SetActive(true);
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            stopMovingdown.SetActive(true);
            print("other");
        }
        //add else statement here
        
    }

}
//this script is to grab onto the crate when it collides with the object this script is on.