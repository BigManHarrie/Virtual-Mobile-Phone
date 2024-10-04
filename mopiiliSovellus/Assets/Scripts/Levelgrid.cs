using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelGrid : MonoBehaviour
{
    private Vector2Int foodGridPosition;
    private int width;
    private int height;
    Collider2D myCollider;
    public TextMeshProUGUI burgerText;

    public GameObject foodPrefab;
    public int collectedFoods = 0;
    public GameObject player;
    public RectTransform canvasRect;

    private GameObject currentFood;
    Vector3 savedPosition;
    public Slider volumeSlider;

    public AudioClip[] audioClips;
    // Constructor to initialize the grid dimensions
    public LevelGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    private void Start()
    {
        collectedFoods = 0;
        burgerText.text = "Burgers: " + collectedFoods;
        myCollider = GetComponent<Collider2D>();
        SpawnFood();
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }
    private void FixedUpdate()
    {
        if (currentFood.transform.position != savedPosition)
        {
            FoodCollected();
        }
    }
    // Start is called before the first frame update
    private void SpawnFood()
    {
        

        // Calculate the boundaries for spawning food within the canvas
        float minX = -400;
        float maxX = 400;
        float minY = -700;
        float maxY = 700;

        // Generate random coordinates within the canvas boundaries
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Instantiate the food prefab at the random position
        currentFood = Instantiate(foodPrefab, new Vector2(randomX, randomY), Quaternion.identity);

        // Set the food's parent to the canvas
        currentFood.transform.SetParent(canvasRect, false);
        savedPosition = currentFood.transform.position;
    }

    public void FoodCollected()
    {
        burgerText.text = "Burgers: " + collectedFoods;
        collectedFoods++;
        player.transform.localScale += new Vector3(0.3f, 1f, 0f);
        // Destroy the current food
        Destroy(currentFood);
        Debug.Log("Osui Ruakaan");
        PlayRandomClip();
        // Spawn a new food item
        SpawnFood();
        
        if (collectedFoods == 666)
        {
            SceneManager.LoadSceneAsync(9);
        }
    }
    void PlayRandomClip()
    {
        GameObject audioObject = new GameObject("TempAudio");
        audioObject.transform.parent = transform; // Optional: Make it a child of this GameObject

        // Add an AudioSource component to the new GameObject
        AudioSource audioSource = audioObject.AddComponent<AudioSource>();

        int randomIndex = Random.Range(0, audioClips.Length);
        audioSource.clip = audioClips[randomIndex];
        audioSource.Play();

        // Destroy the GameObject (and the AudioSource) when the clip is done
        Destroy(audioObject, audioSource.clip.length);
    }
}
