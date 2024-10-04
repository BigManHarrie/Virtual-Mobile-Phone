using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Viittaus PlayerMovement komponenttiin, joka hallitsee pelaajan liikett‰
    public PlayerMovement playerMovement;

    // Vector2 arvo, joka m‰‰ritt‰‰ liikkeen suunnan (esim. x- ja y-suunnat)
    public Vector2 direction;

    // Kutsutaan, kun pelaaja painaa nappia
    public void OnPointerDown(PointerEventData eventData)
    {
        // Aloitetaan liikkuminen annetussa suunnassa
        playerMovement.StartMoving(direction);
    }

    // Kutsutaan, kun pelaaja p‰‰st‰‰ irti napista
    public void OnPointerUp(PointerEventData eventData)
    {
        // Lopetetaan liike
        playerMovement.StopMoving();
    }
}
