using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubValues : MonoBehaviour
{
    //loading zones objects
    public GameObject DoorTim;
    public GameObject DoorVincent;
    public GameObject DoorJoeri;
    public GameObject DoorRichard;

    //sprites
    public GameObject TimDoor;

    public GameObject VincentDoorOpen;
    public GameObject VincentDoorClosed;

    public GameObject JoeriDoorOpen;
    public GameObject JoeriDoorClosed;

    public GameObject RichardDoorOpen;
    public GameObject RichardDoorClosed;

    void Start()
    { 
        //alle deuren zijn open, behalve richard die is dicht
        DoorTim.SetActive(false);
        DoorVincent.SetActive(false);
        DoorJoeri.SetActive(false);
        DoorRichard.SetActive(true);

        //voor sprites
        TimDoor.SetActive(true);

        VincentDoorOpen.SetActive(true);
        VincentDoorClosed.SetActive(false);

        JoeriDoorOpen.SetActive(true);
        JoeriDoorClosed.SetActive(false);

        RichardDoorOpen.SetActive(false);
        RichardDoorClosed.SetActive(true);
    }

    void Update()
    {
        //checked of de playerprefs 1 is, als dat zo is gaat de deur dicht
        if (PlayerPrefs.GetInt("DoorTim") == 1)
        {
            DoorTim.SetActive(true);
            TimDoor.SetActive(false);
            print("DoorTimHasClosed");
        }

        if (PlayerPrefs.GetInt("DoorVincent") == 1)
        {
            DoorVincent.SetActive(true);
            VincentDoorOpen.SetActive(false);
            VincentDoorClosed.SetActive(true);
            print("DoorVincentHasClosed");
        }

        if (PlayerPrefs.GetInt("DoorJoeri") == 1)
        {
            DoorJoeri.SetActive(true);
            JoeriDoorOpen.SetActive(false);
            JoeriDoorClosed.SetActive(true);
            print("DoorJoeriHasClosed");
        }

        //als alle drie de andere deuren dicht zijn gaat de deur van richard open
        if (PlayerPrefs.GetInt("DoorJoeri") == 1 && PlayerPrefs.GetInt("DoorVincent") == 1 && PlayerPrefs.GetInt("DoorTim") == 1)
        {
            DoorRichard.SetActive(false);
            RichardDoorOpen.SetActive(true);
            RichardDoorClosed.SetActive(false);
            print("DoorRichardHasOpend");
        }
    }
}
