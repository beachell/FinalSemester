using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craneUpdeactivate : MonoBehaviour
{
    GameObject parent;
    public GameObject SoundObject;
    public GameObject stopMovingUp;
    
    // Start is called before the first frame update
    void Start()
    {
        SoundObject.SetActive(false);        
    }

    private void OnCollisionEnter(Collision other)
    {
        print("collided top");
       stopMovingUp.SetActive(true);
       
        
    }
}
