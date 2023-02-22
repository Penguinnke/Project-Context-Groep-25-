using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement voor de tweede speler zonder de animator
public class Player_2 : MonoBehaviour
{

    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow)) //boven
        {
            pos.y += moveSpeed * Time.deltaTime;
        }

        
        if (Input.GetKey(KeyCode.DownArrow)) //onder
        {
            pos.y -= moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow)) //rechts
        {
            pos.x += moveSpeed * Time.deltaTime;
        }

        
        if (Input.GetKey(KeyCode.LeftArrow)) //links
        {
            pos.x -= moveSpeed * Time.deltaTime;
        }

        transform.position = pos;  
    }
}
