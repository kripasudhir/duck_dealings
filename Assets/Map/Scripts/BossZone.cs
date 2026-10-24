using UnityEngine;
using UnityEngine.Events;

public class BossZone : MonoBehaviour
{
    [SerializeField] private UnityEvent onPlayerEnter;
    private bool triggered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            Debug.Log("Battle start!");
            onPlayerEnter.Invoke();
        }
    }
}
