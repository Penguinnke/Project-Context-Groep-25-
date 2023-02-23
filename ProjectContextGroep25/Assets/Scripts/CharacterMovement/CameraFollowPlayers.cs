using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayers : MonoBehaviour
{
    public List<Transform> Players;

    public Vector3 Offset;

    private void LateUpdate()
    {
        if(Players.Count == 0)
           return;
        

        Vector3 Center = GetCenter();

        Vector3 NewPos = Center + Offset;

        transform.position = NewPos;
    }
    Vector3 GetCenter()
    {
        //if player count is 1 then it just gives it normally
        if (Players.Count == 1)
        {
            return Players[0].position;
        }

        //if player count is higher than 1 finds the middle point of all players
        var bounds = new Bounds(Players[0].position, Vector3.zero);
        for (int i = 0; i < Players.Count; i++)
        {
            bounds.Encapsulate(Players[i].position);
        }

        return bounds.center;
    }
}
