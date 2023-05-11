using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public GameObject[] music;
    void Start(){
        music = GameObject.FindGameObjectsWithTag ("gameMusic");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        foreach (var i in music)
        {
            i.GetComponent<AudioSource>().Play();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
}
