using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterDoorTrigger : MonoBehaviour
{
    public int timesEnter;
    
    
    HingeJoint trigger;
    JointSpring spring;
    JointLimits limits = new JointLimits();

    void Start()
    {
        spring.targetPosition = 45;
        spring.spring = 500;
        spring.damper = 100;


        trigger = GetComponentInChildren<HingeJoint>();
        trigger.useSpring = false;
        timesEnter = 0;
        
    }
   
    void OnTriggerEnter()
    {
        print("enter");
        timesEnter++;
        if (timesEnter == 2)
        {
            spring.targetPosition = 45;
            spring.spring = 500;
            spring.damper = 100;

            limits.max = 45;
            
            trigger.spring = spring;
            trigger.limits = limits;
            trigger.useSpring = true;

            timesEnter = 0;
        }
        else if (timesEnter == 1)
        {
            spring.targetPosition = 0;
            limits.max = 0;

            trigger.spring = spring;
            trigger.limits = limits;

        }

    }

    
}
