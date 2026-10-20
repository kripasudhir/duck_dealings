using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position;
            other.attachedRigidbody.linearVelocity = Vector3.zero;
            Debug.Log("Duck respawned.");
        }
    }
}
