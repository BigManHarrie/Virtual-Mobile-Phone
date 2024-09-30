using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayDisplayText : MonoBehaviour
{
    public TextMeshProUGUI viikonpaiva;

    void Start()
    {

        if (viikonpaiva == null)
        {
            viikonpaiva = GetComponent<TextMeshProUGUI>();
        }
    }


    void Update()
    {
        viikonpaiva.text = System.DateTime.Now.DayOfWeek.ToString();
    }
}