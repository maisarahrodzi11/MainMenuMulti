using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MukaDepan : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("EndGame");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MukaDepan");
    }

    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Player Has Quit The Game");
    }
}
