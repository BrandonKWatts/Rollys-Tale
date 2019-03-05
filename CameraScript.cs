using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class CameraScript : MonoBehaviour
{

    Transform Player;
    public float xOffset = 0;
    public float yOffset = 0;
    public float zOffset = 0;
    Vector3 playerPosition;


    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        playerPosition.x = Player.position.x + xOffset;
        playerPosition.y = Player.position.y + yOffset;
        playerPosition.z = Player.position.y + zOffset;
        transform.position = playerPosition;
    }

}

