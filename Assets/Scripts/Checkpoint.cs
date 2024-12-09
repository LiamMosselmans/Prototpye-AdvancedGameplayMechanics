using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private PlayerRespawn respawn;
    private BoxCollider boxCollider;
    [SerializeField]
    private ParticleSystem waypointParticleSystem;

    void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<PlayerRespawn>();
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            respawn.respawnPoint = this.gameObject;
            boxCollider.enabled = false;
        }
    }
}
