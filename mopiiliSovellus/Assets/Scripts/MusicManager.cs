using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class MusicManager : MonoBehaviour
{
    public Slider volumeSlider;//‰‰ni slaideri
    public AudioMixer audioMixer;//audiomixeri
    public TextMeshProUGUI valueText;//‰‰nenkovuuden m‰‰r‰n numero
    
    // Start is called before the first frame update
    void Start()
    {
        LoadVolume();
    }

    public void UpdateSoundVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        valueText.text = "Volume: " + volumeSlider.value.ToString("F0");//pyˆrist‰‰ nollaan ekaan desimaaliin
    }
    public void SaveVolume()
    {
        audioMixer.GetFloat("Volume", out float volume);
        PlayerPrefs.SetFloat("Volume", volume);//tallentaa ‰‰nenkovuuden muistiin
    }
    public void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");//lataa ‰‰nenkovuuden muistista
    }
}
