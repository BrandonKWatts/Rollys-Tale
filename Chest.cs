
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    public static bool WinScene = false;
    public GameObject WinSceneUI;
    private Animator animator;
    public AudioSource chestSound;
    private AudioSource[] allAudioSources;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            StopAllAudio();
            animator.SetTrigger("Collide");
            chestSound.Play();
           
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (WinScene)
            {
                NextLevel();
            }
        }

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneName: "Level 2");
        WinSceneUI.SetActive(false);
        Time.timeScale = 1f;
        WinScene = false;
    }

    public void Win()
    {
        WinSceneUI.SetActive(true);
        Time.timeScale = 0f;
        WinScene = true;
    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }



}

