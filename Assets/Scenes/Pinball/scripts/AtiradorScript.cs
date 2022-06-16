using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtiradorScript : MonoBehaviour
{
    float power;
    public float minPower;
    public float maxPower;
    Rigidbody ballRigidBody = null;

    void Update()
    {
        if (ballRigidBody != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                print("carregando: " + power);

                if (power <= maxPower)
                    power += 250 * Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                ballRigidBody.AddForce(power * Vector3.forward);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bola"))
            ballRigidBody = other.gameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("bola"))
        {
            ballRigidBody = null;
            power = minPower;
        }
    }
}
