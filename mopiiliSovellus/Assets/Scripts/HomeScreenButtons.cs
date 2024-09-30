using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeScreenButtons : MonoBehaviour
{

    public GameObject GoogleIMG;
    public GameObject SlotsIMG;
    float scaleSize = 1.12f;



    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void CameraB()//nappulalla voi lataa tietyn scenen
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void HomeB()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void CalendarB()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void GoogleB()
    {
        StartCoroutine(LoadGoogle());
    }
    public void SlotsB()
    {
        StartCoroutine(LoadSlots());
    }
    public void SettingsB()
    {
        SceneManager.LoadSceneAsync(6);
    }
    IEnumerator LoadGoogle()
    {
        for (int i = 0; i < 15; i++)//kasvattaa apin logon että se avautuu hienosti
        {
            GoogleIMG.transform.localScale += new Vector3(scaleSize, scaleSize, scaleSize);
            yield return new WaitForSeconds(0.01f);
        }
        
        SceneManager.LoadSceneAsync(3);
    }
    IEnumerator LoadSlots()
    {
        for (int i = 0; i < 15; i++)
        {
            SlotsIMG.transform.localScale += new Vector3(scaleSize, scaleSize, scaleSize);
            yield return new WaitForSeconds(0.01f);
        }

        SceneManager.LoadSceneAsync(5);
    }
}
