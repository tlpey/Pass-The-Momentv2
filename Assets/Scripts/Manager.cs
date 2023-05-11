using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel, pauseButton;
    public GameObject[] music;
    void Start(){
        music = GameObject.FindGameObjectsWithTag ("gameMusic");
    }
    public void _PauseButton()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
                foreach (var i in music)
        {
            i.GetComponent<AudioSource>().Pause();
        }
    }
    public void _ResumeButton()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
                foreach (var i in music)
        {
            i.GetComponent<AudioSource>().Play();
        }
    }
    public void _MenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScreen");
        foreach (var i in music)
        {
            i.GetComponent<AudioSource>().Stop();
        }
    }
}
