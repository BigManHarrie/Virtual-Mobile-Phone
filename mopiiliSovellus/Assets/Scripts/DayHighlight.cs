using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DayHighlight : MonoBehaviour
{
    // Viittaukset tekstielementteihin, joissa jokaisen p‰iv‰n numero n‰ytet‰‰n
    public TextMeshProUGUI currentDayText;
    public TextMeshProUGUI dayonetext;
    public TextMeshProUGUI daytwotext;
    public TextMeshProUGUI daythreetext;
    public TextMeshProUGUI dayfourtext;
    public TextMeshProUGUI dayfivetext;
    public TextMeshProUGUI daysixtext;
    public TextMeshProUGUI dayseventext;
    public TextMeshProUGUI dayeighttext;
    public TextMeshProUGUI dayninetext;
    public TextMeshProUGUI daytentext;
    public TextMeshProUGUI dayeleventext;
    public TextMeshProUGUI daytwelvetext;
    public TextMeshProUGUI daythirteentext;
    public TextMeshProUGUI dayfourteentext;
    public TextMeshProUGUI dayfifteentext;
    public TextMeshProUGUI daysixteentext;
    public TextMeshProUGUI dayseventeentext;
    public TextMeshProUGUI dayeighteentext;
    public TextMeshProUGUI daynineteentext;
    public TextMeshProUGUI daytwentytext;
    public TextMeshProUGUI daytwentyonetext;
    public TextMeshProUGUI daytwentytwotext;
    public TextMeshProUGUI daytwentythreetext;
    public TextMeshProUGUI daytwentyfourtext;
    public TextMeshProUGUI daytwentyfivetext;
    public TextMeshProUGUI daytwentysixtext;
    public TextMeshProUGUI daytwentyseventext;
    public TextMeshProUGUI daytwentyeighttext;
    public TextMeshProUGUI daytwentyninetext;
    public TextMeshProUGUI daythirtytext;
    public TextMeshProUGUI daythirtyonetext;

    // Kutsutaan, kun skripti alustetaan
    void Start()
    {
        // Asetetaan currentDayText tekstikentt‰‰n nykyinen p‰iv‰
        currentDayText.text = System.DateTime.Now.Day.ToString();

        // Kutsutaan funktiota, joka korostaa nykyisen p‰iv‰n
        HighlightCurrentDay();
    }

    // Funktio, joka korostaa nykyisen p‰iv‰n muuttamalla sen v‰rin punaiseksi
    void HighlightCurrentDay()
    {
        // Haetaan nykyinen p‰iv‰ (1ñ31) j‰rjestelm‰n kellosta
        int currentDay = System.DateTime.Now.Day;

        // K‰ytet‰‰n switch-lauseketta nykyisen p‰iv‰n perusteella
        switch (currentDay)
        {
            case 1:
                dayonetext.color = Color.red;
                break;
            case 2:
                daytwotext.color = Color.red;
                break;
            case 3:
                daythreetext.color = Color.red;
                break;
            case 4:
                dayfourtext.color = Color.red;
                break;
            case 5:
                dayfivetext.color = Color.red;
                break;
            case 6:
                daysixtext.color = Color.red;
                break;
            case 7:
                dayseventext.color = Color.red;
                break;
            case 8:
                dayeighttext.color = Color.red;
                break;
            case 9:
                dayninetext.color = Color.red;
                break;
            case 10:
                daytentext.color = Color.red;
                break;
            case 11:
                dayeleventext.color = Color.red;
                break;
            case 12:
                daytwelvetext.color = Color.red;
                break;
            case 13:
                daythirteentext.color = Color.red;
                break;
            case 14:
                dayfourteentext.color = Color.red;
                break;
            case 15:
                dayfifteentext.color = Color.red;
                break;
            case 16:
                daysixteentext.color = Color.red;
                break;
            case 17:
                dayseventeentext.color = Color.red;
                break;
            case 18:
                dayeighteentext.color = Color.red;
                break;
            case 19:
                daynineteentext.color = Color.red;
                break;
            case 20:
                daytwentytext.color = Color.red;
                break;
            case 21:
                daytwentyonetext.color = Color.red;
                break;
            case 22:
                daytwentytwotext.color = Color.red;
                break;
            case 23:
                daytwentythreetext.color = Color.red;
                break;
            case 24:
                daytwentyfourtext.color = Color.red;
                break;
            case 25:
                daytwentyfivetext.color = Color.red;
                break;
            case 26:
                daytwentysixtext.color = Color.red;
                break;
            case 27:
                daytwentyseventext.color = Color.red;
                break;
            case 28:
                daytwentyeighttext.color = Color.red;
                break;
            case 29:
                daytwentyninetext.color = Color.red;
                break;
            case 30:
                daythirtytext.color = Color.red;
                break;
            case 31:
                daythirtyonetext.color = Color.red;
                break;
        }
    }
}
