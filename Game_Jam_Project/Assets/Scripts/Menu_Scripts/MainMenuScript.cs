using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    Game_Controller gameController;

    void Start()
    {

        gameController.startButton.SetActive(true);
        gameController.quitButton.SetActive(true);

    }

    public void StartGame()
    {

        SceneManager.LoadScene("Loaded_Room");

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
