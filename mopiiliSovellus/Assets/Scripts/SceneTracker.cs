using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTracker : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);//tallentaa missä scenessä viimeksi oltiin
        PlayerPrefs.Save(); //tallentaa playerprefs
    }
}
