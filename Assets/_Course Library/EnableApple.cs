using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableApple : MonoBehaviour
{
    public GameObject apple;
    public XRSocketInteractor socket;
    //
    private void Start()
    {
        socket.selectEntered.AddListener(EnableAppleActive);
    }

    public void EnableAppleActive(SelectEnterEventArgs obj)
    {
        apple.SetActive(true);
    }
}
