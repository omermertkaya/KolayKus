using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuGo : MonoBehaviour
{
    public void Start()
    {
        ReklamManager.instance.RequestBanner();
    }
    public void TekrarBasla()
    {
        
        SceneManager.LoadScene("Main");
    }

    public void MenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
}
