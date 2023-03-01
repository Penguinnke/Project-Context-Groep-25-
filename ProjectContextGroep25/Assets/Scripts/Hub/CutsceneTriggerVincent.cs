using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTriggerVincent : MonoBehaviour
{ 
    public string Cutscene;
    public GameObject Player1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        //als player 1 in contact komt voert het script uit, prefs zorgt ervoor dat deur dicht gaat (hubvalues script)
        if (other.gameObject == Player1)
        {
            SceneManager.LoadScene(Cutscene);
            print("hello");
            PlayerPrefs.SetInt("DoorVincent", 1);
        }
    }
}
