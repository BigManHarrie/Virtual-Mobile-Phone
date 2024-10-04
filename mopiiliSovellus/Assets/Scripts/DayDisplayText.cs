using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayDisplayText : MonoBehaviour
{
    // Viittaus TextMeshProUGUI komponenttiin, joka n‰ytt‰‰ viikonp‰iv‰n tekstimuodossa
    public TextMeshProUGUI viikonpaiva;

    // Kutsutaan kerran, kun skripti alustetaan
    void Start()
    {
        // Tarkistetaan, onko viikonpaiva komponentti asetettu. Jos ei niin haetaan se GameObjectista.
        if (viikonpaiva == null)
        {
            viikonpaiva = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        // Asetetaan viikonpaiva tekstiksi nykyinen viikonp‰iv‰ (esim. Monday, Tuesday)
        viikonpaiva.text = System.DateTime.Now.DayOfWeek.ToString();
    }
}
