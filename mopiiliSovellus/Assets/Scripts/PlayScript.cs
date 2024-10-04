using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    // Viittaus Unityn Button komponenttiin jota k‰ytet‰‰n pelin aloittamiseen tai scenen vaihtamiseen
    public Button startButton;

    // Kutsutaan kerran, kun objekti alustetaan
    void Start()
    {
        // Lis‰t‰‰n kuuntelija startButton painikkeelle, joka kutsuu StartB metodia, kun painiketta klikataan
        startButton.onClick.AddListener(StartB);
    }

    // Metodi, joka kutsutaan, kun painiketta painetaan
    void StartB()
    {
        // Lataa asynkronisesti scenen numero (8)
        SceneManager.LoadSceneAsync(8);
    }
}
