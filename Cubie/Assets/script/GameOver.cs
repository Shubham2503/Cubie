using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {


    public Text NetscoreText;
    public Text HighscoreText;
    public Text CoinsText;

    private void Start()
    {
        NetscoreText.text = PlayerPrefs.GetInt("NetScore").ToString("0");
        HighscoreText.text = PlayerPrefs.GetInt("HighScore").ToString("0");
        CoinsText.text = PlayerPrefs.GetInt("TotalCoin", 0).ToString("0");

    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
       
    }



}
