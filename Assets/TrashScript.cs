using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class SocketManager : MonoBehaviour
{
    [Header("Socket Settings")]
    public Transform[] sockets; // Assign the sockets in the Inspector
    private List<GameObject> filledSockets = new List<GameObject>();

    [Header("Events")]
    public UnityEvent onAllSocketsFilled;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object filling the socket is valid (you can customize this)
        if (IsValidObject(other.gameObject))
        {
            FillSocket(other.gameObject);
        }
    }

    private void FillSocket(GameObject obj)
    {
        if (filledSockets.Count < sockets.Length && !filledSockets.Contains(obj))
        {
            filledSockets.Add(obj);
            Debug.Log($"Socket filled by: {obj.name}");

            // Check if all sockets are filled
            if (filledSockets.Count >= sockets.Length)
            {
                onAllSocketsFilled.Invoke();
                Debug.Log("All sockets have been filled!");
            }
        }
    }

    private bool IsValidObject(GameObject obj)
    {
        // Add your own logic to determine if the object is valid
        // For example, you could check for a specific tag
        return obj.CompareTag("Fillable"); // Ensure the game object has a tag "Fillable"
    }

    private void OnTriggerExit(Collider other)
    {
        // Optionally handle object removal from the socket
        if (filledSockets.Contains(other.gameObject))
        {
            filledSockets.Remove(other.gameObject);
            Debug.Log($"Socket emptied by: {other.gameObject.name}");
        }
    }
}
