using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentDate : MonoBehaviour
{
    public TextMeshProUGUI aika;
    public TextMeshProUGUI paiva;

    void Start()
    {
        if (aika == null)
        {
            aika = GetComponent<TextMeshProUGUI>();
        }
        if (paiva == null)
        {
            paiva = GetComponent<TextMeshProUGUI>();
        }
    }

    
    void Update()
    {
        aika.text = System.DateTime.Now.ToString("HH:mm");
        paiva.text = System.DateTime.Now.DayOfWeek.ToString();
    }
}
