using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Reference to the door GameObject
    private GameObject door;

    private void Start()
    {
        // Store a reference to the door GameObject
        door = gameObject;
    }

    public void OpenDoor(bool open)
    {
        if (open)
        {
            // Disable the door (makes it disappear)
            door.SetActive(false);
        }
        else
        {
            // Optionally, if you want the door to reappear when the trigger is exited
            door.SetActive(true);
        }
    }
}
