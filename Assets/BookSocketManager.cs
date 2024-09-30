using UnityEngine;

public class BookSocketManager : MonoBehaviour
{
    public GameObject[] sockets; // Assign sockets in the inspector
    public AudioClip soundToPlay; // Assign your sound clip in the inspector
    private AudioSource audioSource;

    private int booksInPlace = 0;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundToPlay;
    }

    public void PlaceBook(GameObject book)
    {
        // Check if the book is in the correct socket
        foreach (GameObject socket in sockets)
        {
            if (book.CompareTag(socket.tag)) // Assuming sockets have tags matching the book colors
            {
                booksInPlace++;
                book.SetActive(false); // Deactivate book after placement
                CheckAllBooksPlaced();
                return;
            }
        }
    }

    private void CheckAllBooksPlaced()
    {
        if (booksInPlace == sockets.Length)
        {
            PlaySound();
        }
    }

    private void PlaySound()
    {
        audioSource.Play();
    }
}