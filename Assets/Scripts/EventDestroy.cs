using UnityEngine;
using UnityEngine.Events;

public class EventDestroy : MonoBehaviour
{
    public UnityEvent onDestroy;

    public void DoEventsAndDestroy()
    {
        onDestroy?.Invoke();
        Destroy(this.gameObject);
    }
}
