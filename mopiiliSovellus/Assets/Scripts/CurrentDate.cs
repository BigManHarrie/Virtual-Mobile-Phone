using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentDate : MonoBehaviour
{
    public TextMeshProUGUI aika;//aika ja p�iv�teksti
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
        aika.text = System.DateTime.Now.ToString("HH:mm");//ottaa nykymaailman ajan ja se n�kyy n�yt�ll�.
        paiva.text = System.DateTime.Now.DayOfWeek.ToString();//ottaa nykymaailman viikonp�iv�n ja se n�kyy n�yt�ll�.
    }
}
