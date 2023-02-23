using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_WithAnimation : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Speed_2", true); //als het true is, ga over naar de movement blend tree
        } else {
            animator.SetBool("Speed_2", false); //als het false is, speel player_idle af
        }

        if (Input.GetKey(KeyCode.UpArrow)) //boven
        {
            pos.y += moveSpeed * Time.deltaTime;
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        }


        if (Input.GetKey(KeyCode.RightArrow)) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 1);
        }
        
        
        if (Input.GetKey(KeyCode.LeftArrow)) //links
        {
            pos.x -= moveSpeed * Time.deltaTime;
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", -1);
        }

        transform.position = pos; 
    }
} 

