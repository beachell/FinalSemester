using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulenceCountdown : MonoBehaviour {
    /*this is the count down for the player to win the game with an ambulence arriving. 
     * The average reponse time across the nation is 15.19 minutes, the shortest being 6 minutes. Need to determine if the player should have to do the full time
     * or to shorten it. 
    */

    //will be activated when the player clicks the 911 button. 
    // Use this for initialization

    public int CountDown = 60;

    public GameObject Victory;

	public void Clicked () {
        StartCoroutine(VictoryCountdown());
	}
	
	// Update is called once per frame
	IEnumerator VictoryCountdown () {
        while (true)
        {

            if (CountDown>0)
            {
                Debug.Log("counting down");
                CountDown--;
            }
            else
            {
                Debug.Log("Victory");
                Victory.SetActive(true);
            }
            yield return new WaitForSeconds(1);

        }


    }
}
