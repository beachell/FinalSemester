using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour {

    public List<string> QuestText = new List<string>() {"Do you have an object to activate?"};
    private int listsizeText = 0;
    //private int listsizeResponse = 0;

    private int i = 0;
    private int m ;
    public GameObject ObjectToBeActivated;

   // public GameObject ResponseText;
    //public GameObject startText; 
    
	// Use this for initialization
	void Start ()
	{
	   // if (ResponseText != null) ResponseText.SetActive(false);
	    if (ObjectToBeActivated != null) ObjectToBeActivated.SetActive(false);

	    listsizeText = QuestText.Count;
        m = QuestText.Count;
        TextRandomizer();
    }
    
    private void OnMouseDown()
    {
        if (m > 1)
        {
            m--;
            TextRandomizer();
           // startText.SetActive(false);
        }
        else {
            this.gameObject.SetActive(false);
            ObjectEnabler();
             }
    }

    void TextRandomizer()
    {
        GetComponent<Text>().text = QuestText[i];
        //This chooses a random text/question
        i++;     
        if (i == 0)
            ObjectEnabler();
    }


    void ObjectEnabler()
    {
      
            ObjectToBeActivated.SetActive(true);
            //Debug.Log("object activated");
     
    }
}
/*
the original script I had wrote.  
    public List<string> QuestText = new List<string>() {"Do you have an object to activate?", "text option 2", "text option 3"};
    public List<string> Response = new List<string>() {"text option 1", "text option 2", "text option 3"};
    private int listsizeText = 0;
    private int listsizeResponse = 0;

    private int i = 0;
    public int m = 10;
    public GameObject ObjectToBeActivated;
    public GameObject ResponseText;
    public GameObject startText;

	// Use this for initialization
	void Start ()
	{
	    if (ResponseText != null) ResponseText.SetActive(false);
	    if (ObjectToBeActivated != null) ObjectToBeActivated.SetActive(false);
	    listsizeText = QuestText.Count;
        listsizeResponse = Response.Count;
        TextRandomizer();
    }

    private void OnMouseDown()
    {
        if (m > 0)
        {
            m--;
            TextRandomizer();
            startText.SetActive(false);
            ResponseRandomizer(ResponseText.GetComponent<TextMesh>());
            ResponseText.SetActive(true);
        }
        else {
            this.gameObject.SetActive(false);
            //activate the pulse script here
        }
    }

    void TextRandomizer()
    {
        //This chooses a random text/question
        i = Random.Range(0, listsizeText);

        GetComponent<TextMesh>().text = QuestText[i];
        if (i == 0)
            ObjectEnabler();
    }

    void ResponseRandomizer(TextMesh myText)
    {
        //This chooses a random text/question
        i = Random.Range(0, listsizeResponse);
        /*GetComponent<TextMesh>()myText.text = Response[i];
        if (i == 0)
            ObjectEnabler();
    }

    void ObjectEnabler()
    {
        i++;
        Debug.Log("object" +
            "" +
            ""+i);
        if (i == 2)
        {
            ObjectToBeActivated.SetActive(true);
            Debug.Log("object activated");
        }
    }
*/
