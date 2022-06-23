using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
    public void egipcia()
    {
        SceneManager.LoadScene("Egipcia");

    }
    public void griega()
    {
        SceneManager.LoadScene("Griega");
    }
    public void maya()
    {
        SceneManager.LoadScene("Maya");
    }
    public void Japonesa()
    {
        SceneManager.LoadScene("Japonesa");
    }
    public void chau()
    {
        PlayerPrefs.DeleteAll();
    }

    public void volver()
    {
        SceneManager.LoadScene("Selector");
    }
}

