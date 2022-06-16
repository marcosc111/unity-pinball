using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roleta : MonoBehaviour
{
    public uint pontuacaoPorFrame = 9;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
            GameManager.Instance.increaseScore(pontuacaoPorFrame);
        }
    }
}
