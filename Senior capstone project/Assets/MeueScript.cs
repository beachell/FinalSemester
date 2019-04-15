using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeueScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GameExit()
    {
        Application.Quit();
        print("quit");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }
}
