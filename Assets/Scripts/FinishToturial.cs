using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishToturial : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "MaleFreeSimpleMovement1")
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
