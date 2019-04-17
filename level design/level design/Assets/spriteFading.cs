using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteFading : MonoBehaviour
{
    public bool onOff = true;
    public GameObject objectToTurnOff;

    private void Start()
    {
        StartCoroutine(light());
    }

    // Update is called once per frame
    IEnumerator light()
    {
        while (true)
        {
            if (onOff == onOff)
            {
                yield return onOff = !onOff;
                objectToTurnOff.SetActive(onOff);
                print(onOff);
            }
            yield return new WaitForSeconds(1);
            
        }
     
    }
}
