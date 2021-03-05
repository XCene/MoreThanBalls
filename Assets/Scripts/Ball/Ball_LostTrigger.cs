using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_LostTrigger : MonoBehaviour
{
    GameObject ballGO;
    GameObject ShooterDoorGO;
    HingeJoint hinge;
    
    JointSpring spring = new JointSpring();
    JointLimits limits = new JointLimits();

    private Text ballsCounter;
    private int contador;

    // Start is called before the first frame update
    void Start()
    {
       ballGO = FindObjectOfType<Ball>().gameObject;
        ShooterDoorGO = FindObjectOfType<ShooterDoor>().gameObject;
        hinge = ShooterDoorGO.GetComponent<HingeJoint>();

        ballsCounter = FindObjectOfType<Balls>().GetComponent<Text>();
        contador = int.Parse(ballsCounter.text);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ballGO)
        {
            contador -= 1;
            ballsCounter.text = contador.ToString();
        }
    }

    void OnTriggerStay(Collider other)
    {
        
        if( other.gameObject == ballGO)
        {
            spring.targetPosition = 45;
            spring.damper = 100;
            spring.spring = 500;
            hinge.useSpring = false;


            limits.max = 45;

            hinge.limits = limits;
            hinge.spring = spring;

            ballGO.transform.localPosition = new Vector3(x: 8.5f, y: 0.4f, z: 5f);
            ShooterDoorGO.GetComponentInParent<ShooterDoorTrigger>().timesEnter = 0;
        }
    }
    void Update()
    {
        
    }
}
