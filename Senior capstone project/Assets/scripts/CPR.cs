using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPR : MonoBehaviour {

    public float deathTimer = 40;
    float cprRythm = 0.6667f;
    float badCprRythm = 0.5f;
    float timedCompression = 0;

    bool gameStillPlaying = true;
    bool isCompressionUsed = true;
    bool canStrike;
    public Color ReadyColor;
    public Color NRColor;
    public float colorChange = 0.0001f;  

    //public GameObject CprBox ;
    public GameObject objThing ;
    public GameObject activatedAtStart ;
    public GameObject toDeactivate;
    public GameObject gameOverObject;

    void OnEnable() {
        activatedAtStart.SetActive(true);
        StartCoroutine(Cpr());
        StartCoroutine(GameOver());
      //Renderer rend = GetComponent<Renderer>();
        GetComponent<Renderer>().material.color = Color.Lerp(ReadyColor, NRColor, colorChange);
       
    }

    IEnumerator Cpr()
    {
         while(true)
            {
                yield return new WaitForSeconds(cprRythm);
                GetComponent<Renderer>().material.color = Color.Lerp(ReadyColor, NRColor, colorChange);//green
                if (isCompressionUsed == false)
                {
                    transform.localScale += new Vector3(0.1f, 0.1f, 0);
                 //change the color of the object to red
                 //rend.SharedMaterial.shader = Shader.Find("_Color");
                 //CprBox.SharedMaterial.SetColor("_Color", Color.green);
                 isCompressionUsed = true;
                }
                StartCoroutine(OutOfRythm());
                print("rythm is called");
                //change the color of the object to green
              
            }
    }
    
    IEnumerator OutOfRythm (){
        canStrike = !canStrike;
      //  GetComponent<Renderer>().material.color = Color.Lerp(NRColor, ReadyColor, colorChange);//red
        print ("out of rythm ");
        yield return new WaitForSeconds(badCprRythm);
        canStrike = !canStrike;
        
    }

    IEnumerator GameOver(){
    while (gameStillPlaying)
        {
            deathTimer--;
            yield return new WaitForSeconds(2);
            if (deathTimer == 0)
            {
              //print("game Over");//this is where you call the GameOverScript()
                gameStillPlaying = false;
                objThing.SetActive(true);
                activatedAtStart.SetActive(false);
                toDeactivate.SetActive(false);
                gameOverObject.SetActive(true);
            }
            print("dying"+deathTimer);
        }
    }

        void OnMouseDown()
        {
            GetComponent<Renderer>().material.color = Color.Lerp(NRColor, ReadyColor, colorChange);//red
        timedCompression = Time.deltaTime;
          if (isCompressionUsed == true && canStrike)
        {
            //this is suppose to keep the game going as long as they press the spacebar on rythm
            print("press____"+deathTimer);
            transform.localScale -= new Vector3(0.1f, 0.1f, 0);
            deathTimer++;
            isCompressionUsed = false;
        } else if (isCompressionUsed == false){ //! is the same as saying is opposite of what it currently is.
        print ("out of rythm ");
            GetComponent<Renderer>().material.color = Color.Lerp(NRColor, ReadyColor, colorChange);//red
        }
       timedCompression = timedCompression + 0.1f;
    }
}

/*
 *  public float deathTimer = 40;
    float cprRythm = 1.6667f;
    float badCprRythm = 0.5f;
    float timedCompression = 0;

    bool gameStillPlaying = true;
    bool isCompressionUsed = true;
    bool canStrike;
    public Color ReadyColor;
    public Color NRColor;
    public float colorChange = 0.0001f;

    public GameObject CprBox ;
    //public GameObject objThing ;

    void OnEnable() {
        StartCoroutine(Cpr());
        StartCoroutine(GameOver());
      //Renderer rend = GetComponent<Renderer>();
        GetComponent<Renderer>().material.color = Color.Lerp(ReadyColor, NRColor, colorChange);
        CprBox.SetActive(true);
    }

    IEnumerator Cpr()
    {
         while(true)
            {
                GetComponent<Renderer>().material.color = Color.Lerp(ReadyColor, NRColor, colorChange);//green
                yield return new WaitForSeconds(cprRythm);
                if (isCompressionUsed == false)
                {
                 
                 //change the color of the object to red
                 //rend.SharedMaterial.shader = Shader.Find("_Color");
                 //CprBox.SharedMaterial.SetColor("_Color", Color.green);
                 isCompressionUsed = true;
                 GetComponent<Renderer>().material.color = Color.Lerp(ReadyColor, NRColor, colorChange);//green
                }
                StartCoroutine(OutOfRythm());
                print("rythm is called");
                //change the color of the object to green
              
            }
    }
    
    IEnumerator OutOfRythm (){
        canStrike = !canStrike;
      //  GetComponent<Renderer>().material.color = Color.Lerp(NRColor, ReadyColor, colorChange);//red
        yield return new WaitForSeconds(badCprRythm);
        canStrike = !canStrike;
        
    }

    IEnumerator GameOver(){
    while (gameStillPlaying)
        {
            deathTimer--;
            yield return new WaitForSeconds(2);
            if (deathTimer == 0)
            {
              //print("game Over");//this is where you call the GameOverScript()
                gameStillPlaying = false;
            }
            print("dying"+deathTimer);
        }
    }

 /*   void Update() {
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
        void OnMouseDown()
        {
            print("pressed");
        timedCompression = Time.deltaTime;
          if (isCompressionUsed == true && canStrike)
        {
            //this is suppose to keep the game going as long as they press the spacebar on rythm
            print("press____"+deathTimer);
            deathTimer++;
            GetComponent<Renderer>().material.color = Color.Lerp(NRColor, ReadyColor, colorChange);//red
            isCompressionUsed = false;
        } else if (isCompressionUsed == false){ //! is the same as saying is opposite of what it currently is.
        print ("out of rythm ");
        }
       timedCompression = timedCompression + 0.1f;
    }
}

 */