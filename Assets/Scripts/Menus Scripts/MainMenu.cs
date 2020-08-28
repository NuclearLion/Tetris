using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //for now, this function will load the actual game;
    //updates later, it will load a loadign scree;
    //the loading screen will load the actual game after 2/3f;
    public void LoadingScreen()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
