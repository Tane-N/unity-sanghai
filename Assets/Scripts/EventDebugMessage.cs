using UnityEngine;
using UnityEngine.Events;

public class EventDebugMessage : MonoBehaviour
{
    public string message;

    public void DisplaySetDebugMessage()
    {
        Debug.Log(message);
    }
    
    public void DisplayNewDebugMessage(string newMessage)
    {
        Debug.Log(newMessage);
    }
}
