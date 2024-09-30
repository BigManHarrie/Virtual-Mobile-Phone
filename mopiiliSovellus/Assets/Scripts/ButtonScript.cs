using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    
    public TMP_InputField salasana;//salasana teksti
    public GameObject button1;//kaikki nappulat
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;
    public GameObject Backspace;
    

    private void Start()
    {
    }

    public void b1()//nappulat numeroille
    {
        salasana.text += "1";
        CheckPassword();
    }
    public void b2()
    {
        salasana.text += "2";
        CheckPassword();
    }
    public void b3()
    {
        salasana.text += "3";
        CheckPassword();
    }
    public void b4()
    {
        salasana.text += "4";
        CheckPassword();
    }
    public void b5()
    {
        salasana.text += "5";
        CheckPassword();
    }
    public void b6()
    {
        salasana.text += "6";
        CheckPassword();
    }
    public void b7()
    {
        salasana.text += "7";
        CheckPassword();
    }
    public void b8()
    {
        salasana.text += "8";
        CheckPassword();
    }
    public void b9()
    {
        salasana.text += "9";
        CheckPassword();
    }
    public void b10()
    {
        salasana.text += "0";
        CheckPassword();
    }
    public void BackSpace()
    {
        var pituus = salasana.text.Length;
        salasana.text = salasana.text.Remove(pituus - 1);
    }
    public void CheckPassword()
    {
        Debug.Log(salasana.text);
        Debug.Log(PlayerPrefs.GetInt("salasana"));
        if (salasana.text == PlayerPrefs.GetInt("salasana").ToString())//salasana on 6969
        {
            Debug.Log("Oikea Salasana");
            SceneManager.LoadSceneAsync(1);
        }
    }
}
