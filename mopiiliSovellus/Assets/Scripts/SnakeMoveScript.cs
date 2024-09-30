using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Button buttonUp;
    public Button buttonDown;
    public Button buttonLeft;
    public Button buttonRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Update button listeners to use StartMoving with direction
        buttonUp.onClick.AddListener(() => StartMoving(Vector2.up));
        buttonDown.onClick.AddListener(() => StartMoving(Vector2.down));
        buttonLeft.onClick.AddListener(() => StartMoving(Vector2.left));
        buttonRight.onClick.AddListener(() => StartMoving(Vector2.right));
    }

    void Update()
    {
        // Apply movement to the player
        rb.velocity = movement * moveSpeed;

        // Rotate the player to face the movement direction
        if (movement.magnitude > 0.1f)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            rb.rotation = angle - 90f;
        }
    }

    public void StartMoving(Vector2 dir)
    {
        movement = dir;
    }

    public void StopMoving()
    {
        movement = Vector2.zero; // Stop moving
    }
}
