using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour {
    [SerializeField]
    public Vector3 velocity;
    private bool moving;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moving = true;
            collision.GetComponent<Collider2D>().transform.SetParent(transform);
        }

        if (collision.gameObject.tag == "UnderGround")
        {
            moving = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<Collider2D>().transform.SetParent(null);
    }


    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
            moving = false;
        }
    }
    */

    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position += velocity * Time.deltaTime;
        }
    }
}   

