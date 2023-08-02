using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject optionspanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Play");
        Time.timeScale = 1.0f;

    }
    public void Options()
    {
        gameObject.SetActive(false);
        optionspanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        gameObject.SetActive(true);
        optionspanel.SetActive(false);
    }




}
