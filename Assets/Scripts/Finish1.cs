using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish1 : MonoBehaviour
{
    public GameObject[] music;
    void Start(){
        music = GameObject.FindGameObjectsWithTag ("gameMusic");
    } 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "MaleFreeSimpleMovement1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            foreach (var i in music)
        {
            i.GetComponent<AudioSource>().Stop();
        }
        }
    }
}
