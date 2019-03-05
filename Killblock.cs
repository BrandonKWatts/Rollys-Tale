using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killblock : MonoBehaviour {
    public static bool DeathScene = false;
    public GameObject DeathSceneUI;
    public GameObject Player;
    public AudioSource deathSound;
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(Player);
            Death();
            deathSound.Play();
;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (DeathScene)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                DeathScene = false;
            }
        }

    }

    public void Death()
    {
        DeathSceneUI.SetActive(true);
        DeathScene = true;
    }

}

