using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour
{
    [SerializeField] GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            player.GetComponent<PlayerDeath>().dead = true;
        }
    }
}
