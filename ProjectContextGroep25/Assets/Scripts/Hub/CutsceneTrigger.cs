using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTrigger : MonoBehaviour
{
    public string Cutscene;
    public GameObject Player1;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player1)
        {
            SceneManager.LoadScene(Cutscene);
            print("hello");
        }
    }
}
