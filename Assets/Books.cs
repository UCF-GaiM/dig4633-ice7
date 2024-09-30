using UnityEngine;

public class Book : MonoBehaviour
{
    private BookSocketManager socketManager;

    private void Start()
    {
        socketManager = FindObjectOfType<BookSocketManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Socket")) // Assuming sockets have the tag "Socket"
        {
            socketManager.PlaceBook(gameObject);
        }
    }
}