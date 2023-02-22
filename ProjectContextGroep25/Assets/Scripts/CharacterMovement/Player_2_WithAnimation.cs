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

        if (Input.GetKey(KeyCode.UpArrow)) //boven
        {
            pos.y += moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 1);
            animator.SetFloat("Horizontal", 0);
        } else {
            animator.SetFloat("Speed", 0);
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", -1);
            animator.SetFloat("Horizontal", 0);
        } else {
            animator.SetFloat("Speed", 0);
        }


        if (Input.GetKey(KeyCode.RightArrow)) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
            animator.SetFloat("Speed",2);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", 1);
        } else {
            animator.SetFloat("Speed", 0);
        }
        
        
        if (Input.GetKey(KeyCode.LeftArrow)) //links
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

