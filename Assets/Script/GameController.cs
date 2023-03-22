using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;

    public float spawnTime;
    public float m_spawnTime;

    int m_score;
    bool gameOver;

    Uimaneger m_ui;
    void Start()
    {
        m_spawnTime = 0;
        spawnTime = 1;
        m_ui = FindAnyObjectByType<Uimaneger>();
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if(gameOver == true)
        {
            m_spawnTime = 0;
            m_ui.GameOverPanel(true);
            return;
        }

        if(m_spawnTime <= 0 )
        {
            spawnBall();
            m_spawnTime = spawnTime;
        }
    }
    
    public void score()
    {
        m_score++;
        m_ui.Score("Score:" + m_score);
    }
    public void spawnBall()
    {   
        Vector2 spawnBall = new Vector2(Random.Range(-10, 10), 6);
        Instantiate(ball, spawnBall, Quaternion.identity);
    }
    public void SetGameOver(bool Gameover)
    {
        gameOver = Gameover;
    }
}
