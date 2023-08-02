using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
    public Image BackgroundImg;
    private bool isShown = false;
    private float transition = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShown)

        { 
            transition +=Time.deltaTime;
        BackgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition); }
        return;

    }
    public void TekrarOyna()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/Play");
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene("Scenes/Open");
    }
    public void Cikis()
    {
        Application.Quit();
    }


    public void ToggleEndMenu(float skor)
    {
        //gameObject.SetActive(true);
        scoreText.text = ((int)skor).ToString();
        isShown = true;
       
    }


}
