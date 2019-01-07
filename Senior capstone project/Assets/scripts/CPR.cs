using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPR : MonoBehaviour {

    float deathTimer = 40;
    float cprRythm = 1.733f;
    float badCprRythm = 0.5f;
    float timedCompression = 0;

    bool gameStillPlaying = true;
    bool isCompressionUsed = true;
    bool canStrike;

    public

    void OnEnable() {
        StartCoroutine(Cpr());
        StartCoroutine(GameOver());
    }

    IEnumerator Cpr()
    {
     while(true)
        {
            if (isCompressionUsed == false)
            {
            isCompressionUsed = true;
            }
            StartCoroutine(OutOfRythm());
            yield return new WaitForSeconds(cprRythm);


        }
    }
    IEnumerator OutOfRythm (){

        canStrike = !canStrike;
        yield return new WaitForSeconds(badCprRythm);
        canStrike = !canStrike;

    }

    IEnumerator GameOver(){
    while (gameStillPlaying)
        {
            deathTimer--;
            yield return new WaitForSeconds(1);
            if (deathTimer == 0)
            {
              //print("game Over");//this is where you call the GameOverScript()
                gameStillPlaying = false;
            }
            print("dying");
        }
    }

    void Update() {
        timedCompression = Time.deltaTime;
        
          if (Input.GetKeyDown(KeyCode.Space) && isCompressionUsed == true && canStrike)
        {
            //this is suppose to keep the game going as long as they press the spacebar on rythm
            print("press____"+deathTimer);
            deathTimer++;
            isCompressionUsed = false;

        } else if (Input.GetKeyDown(KeyCode.Space) && isCompressionUsed == false){ //! is the same as saying is opposite of what it currently is.
        print ("out of rythm ");
        }

       timedCompression = timedCompression + 0.1f;


    }
}
