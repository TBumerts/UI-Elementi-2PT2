using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
    //Metode ļauj pārslēgties no UI ainas uz Sākuma ainu
    public void UzSakumu() 
    {
        SceneManager.LoadScene("Sakums",LoadSceneMode.Single);
    }
    //Pašiem jāuztaisa metode,kas pārslēdzno sākuma uz UI ainu
    public void uzUI() 
    {
        SceneManager.LoadScene("UI elementi", LoadSceneMode.Single);
    }
    public void Apturet() 
    {
        Application.Quit();
    }
}
