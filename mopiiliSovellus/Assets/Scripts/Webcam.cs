using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Webcam : MonoBehaviour
{
    WebCamTexture webcam;
    public RawImage img;
    void Start()
    {
        webcam = new WebCamTexture();
        if (webcam == null)
        {
            img.texture = webcam;
        }
        webcam.Play();
    }


}
