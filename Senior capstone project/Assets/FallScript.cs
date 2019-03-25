using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    public Animation anim;

    public GameObject objectToActivate;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        objectToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.isPlaying())
        {
           objectToActivate.SetActive(true);
        }
    }
}
