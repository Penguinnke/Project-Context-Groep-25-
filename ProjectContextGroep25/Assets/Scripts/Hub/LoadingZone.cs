using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingZone : MonoBehaviour
{
    public string Lokaal;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Lokaal);
    }
}
