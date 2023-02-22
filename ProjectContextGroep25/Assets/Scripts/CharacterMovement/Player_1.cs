using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement voor de eerste speler
public class Player_1 : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) //boven
        {
            pos.y += moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);
        } else {
            animator.SetFloat("Speed", 0);
        }

        transform.position = pos; 
        
        if (Input.GetKey("s")) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        } else {
            animator.SetFloat("Speed", 0);
        }

        transform.position = pos; 


        if (Input.GetKey("d")) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 1);
        } else {
            animator.SetFloat("Speed", 0);
        }
        
        transform.position = pos; 
        
        if (Input.GetKey("a")) //links 
        {
            pos.x -= moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", -1);
        } else {
            animator.SetFloat("Speed", 0);
        }

        transform.position = pos; 
    }
} 
