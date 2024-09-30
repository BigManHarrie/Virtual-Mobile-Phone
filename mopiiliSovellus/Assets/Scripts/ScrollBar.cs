using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
public class ScrollbarValueExample : MonoBehaviour
{
    public Scrollbar horizontalScrollbar; 
    public GameObject content;
    bool Scrolled = false;
    public float transformAmount = 19.0f;//kuinka paljon näyttö liikkuu
    int screenWidth;


    private void Start()
    {
    }
    void Update()
    {
        float scrollbarValue = horizontalScrollbar.value;
        Debug.Log("Scrollbar Horizontal Value: " + scrollbarValue);
        if (!Scrolled && scrollbarValue==1.0f)//katsoo liikuttaako käyttäjä näyttöä
        {
            screenWidth = Screen.width;
            int leveys = screenWidth / 14;
            Scrolled = true;
            StartCoroutine(moveContentBack(leveys));
        }
        if (Scrolled && scrollbarValue == 0.0f)
        {
            screenWidth = Screen.width;
            int leveys = screenWidth / 14;
            Scrolled = false;
            StartCoroutine(moveContent(leveys));
        }
    }
    IEnumerator moveContent(int leveys)
    {
        for (int i = 0; i < leveys; i++)
        {
            content.transform.position += new Vector3(transformAmount, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator moveContentBack(int leveys)//liikuttaa näyttöä
    {
        for (int i = 0; i < leveys; i++)
        {
            content.transform.position += new Vector3(-transformAmount, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
