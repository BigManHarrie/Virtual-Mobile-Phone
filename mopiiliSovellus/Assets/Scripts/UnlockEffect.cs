using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    public AudioSource unlockSound;

    void Start()
    {
        string lastScene = PlayerPrefs.GetString("LastScene", "");//lataa miss� sceness� viimeksi oltiin

        if (lastScene == "Lockscreen")//jos oltiin lockscreeniss�, toistetaan unlocksound
        {
            if (unlockSound != null)
            {
                unlockSound.Play();
            }
            else
            {
                Debug.LogWarning("Unlock sound AudioSource is not assigned in the Inspector.");//debugging
            }
        }
    }
}
