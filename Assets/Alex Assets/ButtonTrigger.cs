using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    // Reference to the door script
    public DoorController doorController;

    private void OnTriggerEnter(Collider other)
    {
        // Activate the door when something enters the trigger
        doorController.OpenDoor(true);
    }

    private void OnTriggerExit(Collider other)
    {
        // Deactivate the door when nothing is in the trigger
        doorController.OpenDoor(false);
    }
}
