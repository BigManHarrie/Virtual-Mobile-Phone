using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class PasswordUpdate : MonoBehaviour
{
    public TMP_InputField input;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("salasana"));
        input.text = PlayerPrefs.GetInt("salasana").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdatePassword()
    {
        int inputInt = Int32.Parse(input.text);
        
        PlayerPrefs.SetInt("salasana", inputInt);
        Debug.Log(inputInt);
    }
}
