using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropIce : MonoBehaviour {

    Vector3 start;
    public float speed;

    private void Start()
    {
        start = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
    void Update()
    {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "UnderGround")
        {
            gameObject.transform.position = start;
        }
    }

}



