using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentKuukausi : MonoBehaviour
{
    // Viittaus TextMeshProUGUI komponenttiin, joka n‰ytt‰‰ kuukauden tekstimuodossa
    public TextMeshProUGUI kuukausi;

    // Kutsutaan, kun skripti alustetaan
    void Start()
    {
        // Tarkistetaan, onko kuukausi komponentti asetettu. Jos ei ole, haetaan se GameObjectista.
        if (kuukausi == null)
        {
            kuukausi = GetComponent<TextMeshProUGUI>();
        }
    }

    // Kutsutaan jokaisella ruudunp‰ivityksell‰
    void Update()
    {
        // Aluksi asetetaan kuukausi komponentin teksti nykyisen kuukauden numeroksi
        kuukausi.text = System.DateTime.Now.Month.ToString();

        // Tarkistetaan mik‰ kuukausi on ja muutetaan numero vastaamaan kuukauden nime‰
        if (kuukausi.text == "1")
        {
            kuukausi.text = "January";
        }
        else if (kuukausi.text == "2")
        {
            kuukausi.text = "February";
        }
        else if (kuukausi.text == "3")
        {
            kuukausi.text = "March";
        }
        else if (kuukausi.text == "4")
        {
            kuukausi.text = "April";
        }
        else if (kuukausi.text == "5")
        {
            kuukausi.text = "May";
        }
        else if (kuukausi.text == "6")
        {
            kuukausi.text = "June";
        }
        else if (kuukausi.text == "7")
        {
            kuukausi.text = "July";
        }
        else if (kuukausi.text == "8")
        {
            kuukausi.text = "August";
        }
        else if (kuukausi.text == "9")
        {
            kuukausi.text = "September";
        }
        else if (kuukausi.text == "10")
        {
            kuukausi.text = "October";
        }
        else if (kuukausi.text == "11")
        {
            kuukausi.text = "November";
        }
        else if (kuukausi.text == "12")
        {
            kuukausi.text = "December";
        }
    }
}
