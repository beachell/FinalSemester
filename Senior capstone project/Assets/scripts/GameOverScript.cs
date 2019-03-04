using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
    public float i = 60;

    public GameObject Victory;
	// Use this for initialization
	void OnEnable () {

        StartCoroutine(GameEnder());        
	}

    IEnumerator GameEnder()
    {
        while (true)
        {
            print("count down" + i);
            yield return new WaitForSeconds(1);

            if (i > 0)
            {
                i--;
            }
            else
            {
                Victory.SetActive(true);
            }
        }

    }
}
