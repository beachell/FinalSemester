using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    //public Animation anim;

    public GameObject objectToActivate1;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject DeactivateThis;
    public GameObject DeactivateBG;
    
    // Start is called before the first frame update
    void Start()
    {
      //  anim = GetComponent<Animation>();
        objectToActivate1.SetActive(false);
        objectToActivate2.SetActive(false);
        objectToActivate3.SetActive(false);
        
       StartCoroutine(ActivatedTheNextSceneAfterFall());
    }


    IEnumerator ActivatedTheNextSceneAfterFall()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.6f);
            objectToActivate1.SetActive(true);
            objectToActivate2.SetActive(true);
            objectToActivate3.SetActive(true);
            DeactivateThis.SetActive(false);
            DeactivateBG.SetActive(false);
            
              
        }
    }
}
