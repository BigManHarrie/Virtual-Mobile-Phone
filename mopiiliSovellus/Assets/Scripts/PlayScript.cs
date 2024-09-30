using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public Button startButton;


    void Start()
    {

        startButton.onClick.AddListener(StartB);
    }


    void StartB()
    {
        SceneManager.LoadSceneAsync(8); 
    }
}