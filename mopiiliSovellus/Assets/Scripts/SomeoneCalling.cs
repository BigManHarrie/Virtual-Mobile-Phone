using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SomeoneCalling : MonoBehaviour
{
    public GameObject Calling; //Kaikki julkiset Gameobjectit, kuvat, tekstit ja listat
    public GameObject Answering;
    public Image ProfilePic; //jonkun soitto profiilikuva
    public TextMeshProUGUI Name;
    public Image callingProfilePic; // Jonkun puhelussa oleva profiilikuva
    public TextMeshProUGUI callingName;
    public TextMeshProUGUI Number;
    public TextMeshProUGUI timeText;
    public Sprite[] Kuvat; //profiilikuvat
    public AudioClip[] linesElmeri;//voicelinet
    public AudioClip[] linesJasper;
    bool someOneCalling = false;

    public float time;//ajanmittaus
    public int minutes; 
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        Calling.SetActive(false);
        Answering.SetActive(false);//Laittaa soiton ei n‰kyv‰ksi
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;//laskee aikaa
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);
        if (seconds.ToString().Length < 2)//lis‰‰ nollan sekunttien eteen jos sekuntit ovat yksinumeroisia
        {
            timeText.text = minutes + ":0" + seconds;
        }
        else
        {
            timeText.text = minutes + ":" + seconds;
        }
        RandomizeCall();
    }
    void RandomizeCall()
    {

        int i = Random.Range(0, 1200);//randomisoi soiton mahdollisuuden. Keskim‰‰r‰isesti soitto tulee 1200s / 50 eli kerran 24 sekuntissa
        if (i == 0 && someOneCalling == false)
        {
            Debug.Log("Joku soittaa");
            RandomizeCaller();
            Calling.SetActive(true);
        }
    }
    void RandomizeCaller()
    {
        int i = Random.Range(0,2); //randomisoi soittaako Jasper vai Elmeri
        
        if (i == 0)
        {
            Name.text = "Ermeli";//muuttaa nimen
            Number.text = "+358 44 485 6344";//muuttaa numeron
            ProfilePic.sprite = Kuvat[0];//muuttaa profiilikuvan
            
        }
        else if (i == 1)
        {
            Name.text = "Jaspero";
            Number.text = "+358 40 002 2203";
            ProfilePic.sprite = Kuvat[1];
            
        }
    }
    public void AcceptCall()
    {
        callingProfilePic.sprite = ProfilePic.sprite;
        callingName.text = Name.text;
        someOneCalling = true;
        Answering.SetActive(true);//muuttaa soiton n‰kyv‰ksi
        Calling.SetActive(false);
        Debug.Log("Someonecalling true");
        time = 0f;//resettaa ajan
        if (callingProfilePic.sprite == Kuvat[0])
        {
            StartCoroutine(RandomVoiceLineElmeri());
        }
        else if (callingProfilePic.sprite == Kuvat[1])
        {
            StartCoroutine(RandomVoiceLineJasper());
        }
    }
    public void DeclineCall()
    {
        someOneCalling = false;
        Calling.SetActive(false);
        Answering.SetActive(false);
    }

    IEnumerator RandomVoiceLineElmeri()
    {
        print(linesElmeri.Length);
        Debug.Log("RandomVoiceLine()");
        someOneCalling = true;
        while (someOneCalling==true)
        {
            int i = Random.Range(0, linesElmeri.Length);//ottaa randomilla indexin mink‰ voicelinen kuuluu taustalla
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = linesElmeri[i];
            audioSource.Play();
            float pituus = linesElmeri[i].length;
            Debug.Log("VoiceLine");
            yield return new WaitForSeconds(pituus + 2);//odottaa kaksi sekunttia voicelinen j‰lkeen ett‰ tulee uusi voiceline
            if (i == linesElmeri.Length-1)//Jos voiceline on listan vika elikk‰ moikat, puhelu p‰‰ttyy
            {
                DeclineCall();
            }
        }
    }
    IEnumerator RandomVoiceLineJasper()
    {
        print(linesJasper.Length);
        Debug.Log("RandomVoiceLine()");
        someOneCalling = true;
        while (someOneCalling == true)
        {
            int i = Random.Range(0, linesJasper.Length);
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = linesJasper[i];
            audioSource.Play();
            float pituus = linesJasper[i].length;
            Debug.Log("VoiceLine");
            yield return new WaitForSeconds(pituus + 2);
            if (i == linesJasper.Length-1)
            {
                DeclineCall();
            }
        }
    }
}
