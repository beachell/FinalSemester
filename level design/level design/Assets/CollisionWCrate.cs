using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWCrate : MonoBehaviour
{
    GameObject parent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        other.transform.SetParent(this.transform);
        print("collided");
        other.transform.GetComponent<Rigidbody>().isKinematic = true;
        other.transform.GetComponent<Rigidbody>().useGravity = false;
    }

    private void OnDisable()
    {
        this.transform.DetachChildren();
    }
}
