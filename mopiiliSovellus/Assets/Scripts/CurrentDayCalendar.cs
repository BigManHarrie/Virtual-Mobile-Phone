using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentKuukausi : MonoBehaviour
{
    public TextMeshProUGUI kuukausi;
    

    void Start()
    {
        if (kuukausi == null)
        {
            kuukausi = GetComponent<TextMeshProUGUI>();
        }

    }


    void Update()
    {
        
        kuukausi.text = System.DateTime.Now.Month.ToString();
        if (kuukausi.text == "1")
        {
            kuukausi.text = "January";
        }else if (kuukausi.text == "2")
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
