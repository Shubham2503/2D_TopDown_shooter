using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour {


    public Text HighScoreDisplay;
    public Text scoreDisplay;

    public void Update()
    {
        HighScoreDisplay.text = PlayerPrefs.GetInt("HighScore").ToString();
        scoreDisplay.text = PlayerPrefs.GetInt("NetScore").ToString();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
