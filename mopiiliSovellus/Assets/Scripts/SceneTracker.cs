using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTracker : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);//tallentaa miss� sceness� viimeksi oltiin
        PlayerPrefs.Save(); //tallentaa playerprefs
    }
}
