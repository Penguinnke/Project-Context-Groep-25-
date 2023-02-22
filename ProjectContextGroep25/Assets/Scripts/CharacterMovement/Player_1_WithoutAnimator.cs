using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement voor de eerste speler zonder de animator
public class Player_1_WithoutAnimator : MonoBehaviour
{

    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) //boven
        {
            pos.y += moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey("s")) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d")) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey("a")) //links 
        {
            pos.x -= moveSpeed * Time.deltaTime;
        }

        transform.position = pos; 
    }
} 
