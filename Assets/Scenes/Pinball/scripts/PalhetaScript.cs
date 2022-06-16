using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalhetaScript : MonoBehaviour
{

    public float restAnglePos;
    public float pressedAnglePos;
    public float hitStrength;
    public float palhetaDamper;

    public string lado;

    HingeJoint hinge;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = lado;

        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {

        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = palhetaDamper;

        if (gameObject.CompareTag("palheta_direita"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                spring.targetPosition = pressedAnglePos;

            }
            else
            {
                spring.targetPosition = restAnglePos;
            }
        }

        if (gameObject.CompareTag("palheta_esquerda"))
        {
            if (Input.GetKey(KeyCode.A))
            {
                spring.targetPosition = pressedAnglePos;

            }
            else
            {
                spring.targetPosition = restAnglePos;
            }
        }

        hinge.spring = spring;
    }
}
