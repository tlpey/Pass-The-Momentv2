using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;
    private void OnCollisionEnter(Collision collision)
    {
            if(collision.gameObject.CompareTag("Enemy Body"))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                GetComponent<SimpleSampleCharacterControl>().enabled = false;
                Die();
            }
    }
    void Die()
    {
        Invoke(nameof(ReloadLevel), 1.3f);
        deathSound.Play();
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
