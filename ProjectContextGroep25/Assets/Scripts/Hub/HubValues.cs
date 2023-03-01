using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubValues : MonoBehaviour
{
    public GameObject DoorTim;
    public GameObject DoorVincent;
    public GameObject DoorJoeri;
    public GameObject DoorRichard;

    void Start()
    { 
        //alle deuren zijn open, behalve richard die is dicht
        DoorTim.SetActive(false);
        DoorVincent.SetActive(false);
        DoorJoeri.SetActive(false);
        DoorRichard.SetActive(true);
    }

    void Update()
    {
        //checked of de playerprefs 1 is, als dat zo is gaat de deur dicht
        if (PlayerPrefs.GetInt("DoorTim") == 1)
        {
            DoorTim.SetActive(true);
            print("DoorTimHasClosed");
        }

        if (PlayerPrefs.GetInt("DoorVincent") == 1)
        {
            DoorVincent.SetActive(true);
            print("DoorVincentHasClosed");
        }

        if (PlayerPrefs.GetInt("DoorJoeri") == 1)
        {
            DoorJoeri.SetActive(true);
            print("DoorJoeriHasClosed");
        }

        //als alle drie de andere deuren dicht zijn gaat de deur van richard open
        if (PlayerPrefs.GetInt("DoorJoeri") == 1 && PlayerPrefs.GetInt("DoorVincent") == 1 && PlayerPrefs.GetInt("DoorTim") == 1)
        {
            DoorRichard.SetActive(false);
            print("DoorRichardHasOpend");
        }
    }
}
