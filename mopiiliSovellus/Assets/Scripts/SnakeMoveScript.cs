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
        // Haetaan Rigidbody2D komponentti
        rb = GetComponent<Rigidbody2D>();

        // P�ivitet��n painikkeiden kuuntelijat k�ytt�m��n StartMoving funktiota, joka saa suunnan
        buttonUp.onClick.AddListener(() => StartMoving(Vector2.up));
        buttonDown.onClick.AddListener(() => StartMoving(Vector2.down));
        buttonLeft.onClick.AddListener(() => StartMoving(Vector2.left));
        buttonRight.onClick.AddListener(() => StartMoving(Vector2.right));
    }

    void Update()
    {
        // Liikutetaan pelaajaa
        rb.velocity = movement * moveSpeed;

        // K��nnet��n pelaajaa
        if (movement.magnitude > 0.1f)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            rb.rotation = angle - 90f;
        }

        // Liikutetaan n�pp�imist�n avulla
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartMoving(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            StartMoving(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            StartMoving(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StartMoving(Vector2.right);
        }
    }

    // Funktio joka aloittaa liikkumisen tiettyyn suuntaan
    public void StartMoving(Vector2 dir)
    {
        movement = dir;
    }

    // Funktio joka pys�ytt�� pelaajan liikkumisen
    public void StopMoving()
    {
        movement = Vector2.zero; // Pys�yt� liikkuminen
    }
}
