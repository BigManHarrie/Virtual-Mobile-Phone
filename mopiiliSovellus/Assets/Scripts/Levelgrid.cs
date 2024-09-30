using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    private Vector2Int foodGridPosition;
    private int width;
    private int height;

    // Constructor to initialize the grid dimensions
    public LevelGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    // Start is called before the first frame update
    private void Start()
    {
        SpawnBurger();
    }

    // Method to spawn a burger sprite at a random position
    private void SpawnBurger()
    {
        // Generate random grid position
        foodGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));

        // Create a new GameObject for the burger
        GameObject burgerGameObject = new GameObject("Burger", typeof(SpriteRenderer));

        // Set the sprite for the SpriteRenderer
        SpriteRenderer spriteRenderer = burgerGameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = GameAssets.i.BurgerSprite;

        // Set the position of the burger with a Z-coordinate of -15
        burgerGameObject.transform.position = new Vector3(foodGridPosition.x, foodGridPosition.y, -15);
    }
}
