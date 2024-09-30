using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class QuitScript : MonoBehaviour
{
    public Button quitButton; 

 
    void Start()
    {
        
        quitButton.onClick.AddListener(QuitB);
    }

    
    void QuitB()
    {
        SceneManager.LoadSceneAsync(1); // Load scene 1
    }
}