using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitScript : MonoBehaviour
{
    // Viittaus Unityn Button komponenttiin, jota k‰ytet‰‰n pelin lopettamiseen tai kohtauksen vaihtamiseen
    public Button quitButton;

    // Kutsutaan kerran, kun objekti alustetaan
    void Start()
    {
        // Lis‰t‰‰n kuuntelija quitButton painikkeelle, joka kutsuu QuitB metodia, kun painiketta klikataan
        quitButton.onClick.AddListener(QuitB);
    }

    // Metodi joka ladataan painikkeen painalluksesta
    void QuitB()
    {
        // Lataa asynkronisesti Scene (1)
        SceneManager.LoadSceneAsync(1);
    }
}
