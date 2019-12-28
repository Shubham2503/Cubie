using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text scoreText;
    public Text HighScoreText;
    public Text CoinsText;

    public int sc = 0;
	void FixedUpdate ()
    {
        scoreText.text = sc.ToString("0");
        sc++;
        PlayerPrefs.SetInt("NetScore", sc);
        if(sc > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", sc);
        }
        HighScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString("0");
        CoinsText.text = PlayerPrefs.GetInt("TotalCoin", 0).ToString("0");

    }
    
}
