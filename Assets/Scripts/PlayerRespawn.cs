using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;
    public CharacterController controller;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Temporarily disable the CharacterController to move the player
            if (controller != null)
            {
                controller.enabled = false;
            }

            player.transform.position = respawnPoint.transform.position;
            Debug.Log("Player respawned to position: " + respawnPoint.transform.position);

            // Re-enable the CharacterController after moving the player
            if (controller != null)
            {
                controller.enabled = true;
            }
        }
    }
}