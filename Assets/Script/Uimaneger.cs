using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Uimaneger : MonoBehaviour
{
    public TextMeshProUGUI score;

    public GameObject gameoverpanel;

    public void Score(string txt)
    {
        if(score != null)
        {
            score.text = txt;
        }
    }
    public void GameOverPanel(bool isShow)
    {
        if(gameoverpanel != null)
        {
            gameoverpanel.SetActive(isShow);
        }
    }
}
