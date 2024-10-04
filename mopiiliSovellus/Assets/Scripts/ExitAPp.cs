using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitAPp : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ExitApp());
    }
    IEnumerator ExitApp() // Odottaa 10 sekunttia kunnes sulkee apin
    {
        yield return new WaitForSeconds(10);
        Application.Quit();
    }
}
