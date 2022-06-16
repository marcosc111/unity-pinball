using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUpdate : MonoBehaviour
{
    public Text gameScoreText;

    void Update()
    {
        gameScoreText.text = GameManager.Instance.getScore().ToString();
    }
}
