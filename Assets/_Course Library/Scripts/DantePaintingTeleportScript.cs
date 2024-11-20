using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DantePaintingTeleportScript : MonoBehaviour
{
    public Vector3 inPosition;
    public Vector3 inRotation;
    public Vector3 outPosition;
    public Vector3 outRotation;
    public GameObject player;
    // Start is called before the first frame update
    public void TeleportIn()
    {
        // Set the position
        player.transform.position = inPosition;

        // Set the rotation
        Quaternion rotation = Quaternion.Euler(inRotation);
        player.transform.rotation = rotation;
    }

    public void TeleportOut()
    {
        // Set the position
        player.transform.position = outPosition;

        // Set the rotation
        Quaternion rotation = Quaternion.Euler(outRotation);
        player.transform.rotation = rotation;
    }
}
