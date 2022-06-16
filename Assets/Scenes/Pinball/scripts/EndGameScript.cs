using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
            GameManager.Instance.consumeAttempt();
            if (GameManager.Instance.getAttemptsRemaining() > 0)
            {
                collision.gameObject.transform.position = new Vector3( 9.6f, 0.55f, -13f );
            } else
            {
                Destroy(collision.gameObject);
                print("game over");
            }
        }
    }
}
