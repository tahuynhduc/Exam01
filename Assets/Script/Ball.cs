using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    public void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EndGame"))
        {
            m_gc.SetGameOver(true);
            Debug.Log("Game over");
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            m_gc.score();
            Debug.Log("Score +1");
            Destroy(gameObject);
        }
    }
}
