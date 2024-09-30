using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyDoor : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onSocketsFilled;

    private int onSockets = 0;

    public void CallFunction()
    {
        onSockets++;

        if(onSockets >= 3)
        {
            onSocketsFilled.Invoke();
        }



    }








}
