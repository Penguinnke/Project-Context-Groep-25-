using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement voor de eerste speler met de animator
public class Player_1 : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            animator.SetBool("Speed", true); //als het true is, ga over naar de movement blend tree
        } else {
            animator.SetBool("Speed", false); //als het false is, speel player_idle af
        }

        if (Input.GetKey("w")) //boven
        {
            pos.y += moveSpeed * Time.deltaTime; //zorgt ervoor dat die van plek veranderd
            animator.SetFloat("Vertical", 1); //speelt animatie af naar boven
            animator.SetFloat("Horizontal", 0); //stop andere animaties
        }
        
        if (Input.GetKey("s")) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
            //nimator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        }


        if (Input.GetKey("d")) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
            //animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 1);
        }
        
        
        if (Input.GetKey("a")) //links 
        {
            pos.x -= moveSpeed * Time.deltaTime;
            //animator.SetFloat("Speed",2); 
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", -1);
        }

        transform.position = pos; 
    }
} 
