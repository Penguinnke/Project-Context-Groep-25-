using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_3 : MonoBehaviour
{
    public GameObject TheButton;
    public GameObject TheButton_2;
    public GameObject Scribbles;
    public GameObject Scribbles_BackGround;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    void Start() 
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
            //yield return null;
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            //gameObject.SetActive(false); //End of the dialogue wss veranderen naar een change scene? Hangt af van de tekst
            //TheButton.SetActive(true);
            //TheButton_2.SetActive(true);
            //Scribbles_BackGround.SetActive(true);
            //Scribbles.SetActive(false);
        }
    }
}