using UnityEngine;
using UnityEngine.Events;

public class SocketChecker : MonoBehaviour
{
    public GameObject socket1;
    public GameObject socket2;
    public GameObject socket3;

    public GameObject requiredObject1;
    public GameObject requiredObject2;
    public GameObject requiredObject3;

    public UnityEvent onAllSocketsFilled;

    private void Update()
    {
        if (CheckSockets())
        {
            onAllSocketsFilled.Invoke();
        }
    }

    private bool CheckSockets()
    {
        // Check if each socket has the correct object
        bool socket1Filled = socket1 != null && socket1.CompareTag(requiredObject1.tag);
        bool socket2Filled = socket2 != null && socket2.CompareTag(requiredObject2.tag);
        bool socket3Filled = socket3 != null && socket3.CompareTag(requiredObject3.tag);

        return socket1Filled && socket2Filled && socket3Filled;
    }
}
