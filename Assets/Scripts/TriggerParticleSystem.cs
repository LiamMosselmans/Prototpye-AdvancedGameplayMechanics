using UnityEngine;

public class TriggerParticleSystem : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem particleSystem;
    public string targetTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that enters the trigger has the correct tag
        if (other.CompareTag(targetTag))
        {
            // Check if the particle system is assigned and play it
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }
}
