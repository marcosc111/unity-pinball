using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeImageShow : MonoBehaviour
{

    public bool isImgOn;
    public RawImage img;
    public int lifeId;

    void Start()
    {
        img.enabled = true;
        isImgOn = true;
    }

    void Update()
    {
        int attemptsRemaining = GameManager.Instance.getAttemptsRemaining();
        if (lifeId > attemptsRemaining)
            if (isImgOn)
            {
                img.enabled = false;
                isImgOn = false;
            }
    }
}
