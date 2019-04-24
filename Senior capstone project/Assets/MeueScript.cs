using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeueScript : MonoBehaviour
{
    public GameObject toDeactivate;
    public GameObject gameOverObject;
    // Start is called before the first frame update
    private void Awake()
    {
     toDeactivate.SetActive(false);
     gameOverObject.SetActive(true);
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
