using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public float ScoreCount;
    public float HiScoreCount;

    public bool scoreIncreasing;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore")){
            HiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Skor: " + Mathf.Round(ScoreCount);
        hiScoreText.text="High Score: "+ Mathf.Round(HiScoreCount);
      //  if(scoreIncreasing)
        //{

       // }
        if (ScoreCount>HiScoreCount)
        {
            HiScoreCount = ScoreCount;
            PlayerPrefs.SetFloat("HighScore",HiScoreCount);
        }


    }
}
