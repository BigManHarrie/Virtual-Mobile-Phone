using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlotMachineWorks : MonoBehaviour
{
    public GameObject HandleRotation;// peliobjektit rullien ja vivun hallintaan
    public GameObject Sheet1;
    public GameObject Sheet2;
    public GameObject Sheet3;

    public Image kuva1;// Kuvakomponentit rullien kuville ja voittokuvalle
    public Image kuva2;
    public Image kuva3;
    public Sprite[] kuvat;
    public Image voittoKuva;
    public ParticleSystem particleEffect;

    public Slider volumeSlider;

    Vector3 rotateHandle = new Vector3(0,0,-36);//vektorit vivun pyöritykselle ja rullien liikkeelle
    Vector3 moveSheet = new Vector3(0, 0.4f, 0);
    public int sheetCutOff = 397;//rajat rullien liikkeelle
    public int sheetStart = -555;

    int extraWin = 1;// muuttujat voiton kertoimelle, pelaajan rahoille, panokselle ja voitolle
    int omaRaha = 1000;
    int betti = 100;
    int voitto = 0;
    public TextMeshProUGUI RahaSana;// Tekstikomponentit rahojen, panoksen ja voiton näyttämiseen
    public TextMeshProUGUI BetSana;
    public TextMeshProUGUI VoittoSana;

    bool canSpin = true;

    public AudioSource spotLightSound;//ääniefektit
    public AudioSource winSound;
    public AudioSource addCoinSound;
    public AudioSource handleSound;
    public AudioSource creeperSound;
    public AudioSource jackpotSound;

    private void Start()
    {
        LoadVolume();
    }
    public void LoadVolume()//lataa äänen kovuuden
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }

    public void playSlots()
    {
        if (omaRaha >= 1 && canSpin && omaRaha >= betti) // Tarkistaa, onko pelaajalla tarpeeksi rahaa ja voiko pelata
        {
            BetSana.text = "Bet: " + betti;// päivitä panos ja rahat
            omaRaha -= betti;
            RahaSana.text = "Bank: " + omaRaha;
            StartCoroutine(rotateHandleBar());//käynnistää rullien ja vivun pyörityksen
            StartCoroutine(moveSheets());
            StartCoroutine(moveSheets2());
            StartCoroutine(moveSheets3());
        }
        else
        {
            Debug.Log("ei ole rahaa");   
        }
    }
    public void increaseBet()//nostaa panosta
    {
        int pituus = betti.ToString().Length;//katsoo montako numeroa betissä on
        int lisays = 10;
        for (int i = 0; i < pituus - 2; i++)//nostaa panosta aina sadalla jos betissä on kolme numeroa, tuhannella jos betissä on neljä numeroa jne...
        {
            lisays *= 10;
        }
        betti +=  lisays;
        BetSana.text = "Bet: " + betti;//muuttaa betTekstin 
        addCoinSound.Play();//ääniefekti
    }
    public void maxBet()//ottaa maksimipanoksen
    {
        if (omaRaha >= 0)
        {
            betti = omaRaha;
        }
        BetSana.text = "Bet: " + betti;
        addCoinSound.Play();
    }
    public void decreaseBet()//vähentää panosta
    {
        betti /= 2;
        BetSana.text = "Bet: " + betti;
    }


    IEnumerator rotateHandleBar()
    { 
        handleSound.Play();
        for (int i = 0; i < 50; i++) //pyörittää vipua
        {
            HandleRotation.transform.Rotate(rotateHandle);
            yield return new WaitForSeconds(0.012f);
        }
    }
    IEnumerator moveSheets()
    {
        kuva1.sprite = kuvat[kuvat.Length - 1];// asetaa alkutilan
        Vector3 currentPosition = Sheet1.transform.position;
        currentPosition.y = sheetStart;
        for (int i = 0; i < 50; i++)// liikutaa rullia ylöspäin
        {
            if (Sheet1.transform.position.y > sheetCutOff)
            {
                Sheet1.transform.position = currentPosition;
            }
            Sheet1.transform.position += moveSheet;
            
            yield return new WaitForSeconds(0.03f);
        }
        valihteKuva(kuva1);//valitsee kuvan

        Sheet1.transform.position = currentPosition; //siirtää rullan pois näkyviltä
        spotLightSound.Play();//ääniefekti
    }
    IEnumerator moveSheets2()
    {
        kuva2.sprite = kuvat[kuvat.Length - 1];
        Vector3 currentPosition2 = Sheet2.transform.position;
        currentPosition2.y = sheetStart;
        for (int i = 0; i < 70; i++)
        {
            if (Sheet2.transform.position.y > sheetCutOff)
            {
                Sheet2.transform.position = currentPosition2;
            }
            Sheet2.transform.position += moveSheet;

            yield return new WaitForSeconds(0.03f);
        }
        valihteKuva(kuva2);

        Sheet2.transform.position = currentPosition2;
        spotLightSound.Play();
    }
    IEnumerator moveSheets3()
    {
        int valiKasi = betti;//nytten betin muutos kesken pyörityksen ei vaihda voittosummaa
        canSpin = false;//ei voi pyörittää
        voittoKuva.sprite = kuvat[5];
        kuva3.sprite = kuvat[kuvat.Length - 1];
        Vector3 currentPosition3 = Sheet3.transform.position;
        currentPosition3.y = sheetStart;
        for (int i = 0; i < 90; i++)
        {
            if (Sheet3.transform.position.y > sheetCutOff)
            {
                Sheet3.transform.position = currentPosition3;
            }
            Sheet3.transform.position += moveSheet;

            yield return new WaitForSeconds(0.03f);
        }
        valihteKuva(kuva3);
        Sheet3.transform.position = currentPosition3;

        if (kuva1.sprite == kuva2.sprite && kuva2.sprite == kuva3.sprite)//tarkistaa voittoyhdistelmät
        {
            voittoKuva.sprite = kuva2.sprite;
            extraWin = 5;//jos sai kolme samaa, saa viidenkertaisen voittosumman kahden samaan verrattuna
            jackpotSound.Play();
            particleEffect.Play();
        }
        else if (kuva1.sprite == kuva2.sprite || kuva2.sprite == kuva3.sprite)//tarkistaa voittoyhdistelmät
        {
            voittoKuva.sprite = kuva2.sprite;
            extraWin = 1;
        }
        else if (kuva1.sprite == kuva3.sprite)//tarkistaa voittoyhdistelmät
        {
            voittoKuva.sprite = kuva1.sprite;
            extraWin = 1;
        }
        getThatMoney(valiKasi);
        canSpin = true;
        spotLightSound.Play();
    }

    void valihteKuva(Image kuva)//valitsee randomilla, mitä voittaa
    {
        int randomNum = Random.Range(1, 101);
        if (randomNum <= 15)
        {
            kuva.sprite = kuvat[0];
        }else if (randomNum <= 45)//default 45
        {
            kuva.sprite = kuvat[1];
        }else if (randomNum <= 75)
        {
            kuva.sprite = kuvat[2];
        }else if (randomNum <= 90)
        {
            kuva.sprite = kuvat[3];
        }else if (randomNum <= 100)
        {
            kuva.sprite = kuvat[4];
        }
    }
    void getThatMoney(int valiKasi)//laskee paljonko rahaa on voittanut
    {
        if (voittoKuva.sprite == kuvat[0])
        {
            VoittoSana.text = "-" + omaRaha * 0.75f;
            omaRaha /= 4 / extraWin;//häviää rahaa
            creeperSound.Play();
        }else if (voittoKuva.sprite == kuvat[1])
        {
            voitto = valiKasi * 2 * extraWin;
            omaRaha += voitto;
            winSound.Play();
            VoittoSana.text = "+" + voitto;
        }
        else if (voittoKuva.sprite == kuvat[2])
        {
            voitto = valiKasi * 5 * extraWin;
            omaRaha += voitto;
            winSound.Play();
            VoittoSana.text = "+" + voitto;
        }
        else if (voittoKuva.sprite == kuvat[3])
        {
            voitto = valiKasi * 10 * extraWin;
            omaRaha += voitto;
            winSound.Play();
            VoittoSana.text = "+" + voitto;
        }
        else if (voittoKuva.sprite == kuvat[4])
        {
            voitto = valiKasi * 100 * extraWin;
            omaRaha += voitto;
            winSound.Play();
            VoittoSana.text = "+" + voitto;
        }
        RahaSana.text = "Bank: " + omaRaha;
        
    }
}