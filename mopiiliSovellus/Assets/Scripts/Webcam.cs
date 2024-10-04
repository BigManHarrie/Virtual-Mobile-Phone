using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Webcam : MonoBehaviour
{
    // Muuttuja, joka tallentaa WebCamTexture olion, joka edustaa verkkokameran videovirtaa
    WebCamTexture webcam;

    // Viittaus UI:n RawImage komponenttiin, jossa verkkokameran videovirta n‰ytet‰‰n
    public RawImage img;

    // Kutsutaan kerran, kun skripti alustetaan
    void Start()
    {
        // Luodaan uusi WebCamTexture instanssi, joka p‰‰see verkkokameran videovirtaan
        webcam = new WebCamTexture();

        // Tarkistetaan, ettei verkkokamera ole tyhj‰ (null)
        if (webcam == null)
        {
            // Asetetaan RawImage komponentin tekstuuriksi verkkokameran video
            img.texture = webcam;
        }

        // Aloitetaan verkkokameran videovirran toisto (verkkokameran aktivointi)
        webcam.Play();
    }
}
