using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(Enemy.gameObject);
    }
}
