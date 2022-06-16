using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private uint score;
    private int attemptsRemaining = 3;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }
    void Awake()
    {
        _instance = this;
    }

    public int getAttemptsRemaining()
    {
        return this.attemptsRemaining;
    }

    public uint getScore()
    {
        return this.score;
    }

    public void increaseScore(uint value)
    {
        this.score += value;
    }

    public void consumeAttempt()
    {
        this.attemptsRemaining -= 1;
    }

    public void resetGame()
    {
        attemptsRemaining = 3;
    }
}