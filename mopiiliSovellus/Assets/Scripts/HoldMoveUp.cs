using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerMovement playerMovement;
    public Vector2 direction;

    public void OnPointerDown(PointerEventData eventData)
    {
        playerMovement.StartMoving(direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        playerMovement.StopMoving();
    }
}
