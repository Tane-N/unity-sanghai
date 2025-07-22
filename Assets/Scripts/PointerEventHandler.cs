using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerEventHandler : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    public UnityEvent onPointerClick;
    public UnityEvent onPointerDown;
    public UnityEvent onPointerUp;
    public UnityEvent onPointerEnter;
    public UnityEvent onPointerExit;


    public void OnPointerClick(PointerEventData eventData)
    {
        onPointerClick?.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        onPointerDown?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        onPointerUp?.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        onPointerEnter?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onPointerExit?.Invoke();
    }
}
