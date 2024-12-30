using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform targetLocation;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = targetLocation.position;
        }
    }
}

