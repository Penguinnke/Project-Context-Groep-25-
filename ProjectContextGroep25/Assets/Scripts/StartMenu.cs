using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string MainGame;

    public GameObject ControlsScreen;
    public GameObject SettingsScreen;

    public void StartGame()
    {
        SceneManager.LoadScene(MainGame);
    }

    public void OpenControls()
    {
        ControlsScreen.SetActive(true);
    }

    public void CloseControls()
    {
        ControlsScreen.SetActive(false);
    }

    public void OpenSettings()
    {
        SettingsScreen.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Quit");
    }
}
