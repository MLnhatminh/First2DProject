using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;

    public void SetScoreText(string text)
    {
        if(scoreText)
        {
            scoreText.text = text;
        }
    }

    public void ShowGameOver(bool isShowOver)
    {
        if(gameOverPanel)
        {
            gameOverPanel.SetActive(isShowOver);
        }
    }
}
