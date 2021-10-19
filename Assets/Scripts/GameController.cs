using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    UIManager m_uiManager;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (IsGameOver())
        {
            m_spawnTime = 0;
            m_uiManager.ShowGameOver(true);
            m_uiManager.SetScoreText("Score: " + m_score);
            return;
        }

        if (m_spawnTime <= 0)
        {
            SpawnBall();
            m_spawnTime = spawnTime;
        }

    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-4, 4), 6);

        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void Replay()
    {
        m_score = 0;
        m_isGameOver = false;
        m_uiManager.SetScoreText("Score: " + m_score);
        m_uiManager.ShowGameOver(false);
    }

    public void SetScore(int value)
    {
        m_score = value;
    }

    public int GetScore()
    {
        return m_score;
    }

    public void IncrementScore()
    {
        m_score++;
        m_uiManager.SetScoreText("Score: " + m_score);
    }

    public bool IsGameOver()
    {
        return m_isGameOver;
    }

    public void SetGameOverState(bool state)
    {
        m_isGameOver = state;
    }
}
