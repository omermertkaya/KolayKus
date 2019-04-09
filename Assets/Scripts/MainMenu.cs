using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class MainMenu : MonoBehaviour
{


   
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
       
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }



}
