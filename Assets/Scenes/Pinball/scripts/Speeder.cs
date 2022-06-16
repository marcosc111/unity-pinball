using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeder : MonoBehaviour
{
    public uint pontuacao = 250;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bola"))
        {
            Rigidbody bola = other.gameObject.GetComponent<Rigidbody>();
            bola.AddForce(250 * Vector3.back);

            GameManager.Instance.increaseScore(pontuacao);
        }
    }
}
