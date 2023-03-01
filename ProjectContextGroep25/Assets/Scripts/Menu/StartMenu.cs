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

    public void ResetGame()
    {
        //reset alle prefs to 0 zodat de deuren weer open gaan en richards deur weer dicht (hubvalues script)
        PlayerPrefs.SetInt("DoorTim", 0);
        PlayerPrefs.SetInt("DoorVincent", 0);
        PlayerPrefs.SetInt("DoorJoeri", 0);
        print("Game has been reset");

    }
}
