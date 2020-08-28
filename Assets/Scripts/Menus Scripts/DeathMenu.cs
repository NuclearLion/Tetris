using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public string mainMenuSceneToLoad;
    public string mainSceneToLoad;

    public void Respawn()
    {
        SceneManager.LoadScene(mainSceneToLoad);
    }

    public void Quit()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneToLoad);
    }

}
