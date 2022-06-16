using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoTipo1 : MonoBehaviour
{
    public float baseForce = 120.0f;

    private uint pontuacao = 10;

    private void Start()
    {
        Color c = new Color(baseForce/255, 0, 0);
        var renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", c);

        this.pontuacao = (uint) baseForce * 2;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
            Rigidbody bola = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 dir = transform.position - bola.transform.position;
            bola.AddForce(baseForce * 2 * dir);

            GameManager.Instance.increaseScore(pontuacao);
        }
    }

}
