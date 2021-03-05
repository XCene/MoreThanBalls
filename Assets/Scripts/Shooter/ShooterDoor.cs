using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterDoor : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip ballHit;
    HingeJoint hinge;
    JointSpring spring = new JointSpring();
    JointLimits limits = new JointLimits();

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        audioSource = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.GetComponent<Ball>())
        {
            audioSource.PlayOneShot(ballHit,2.5f);

            spring.targetPosition = 0;
            spring.damper = 100;
            spring.spring = 500;

            
            hinge.spring = spring;

            StartCoroutine(restoreLimitsMax());
        }
    }

    IEnumerator restoreLimitsMax()
    {
        yield return new WaitForSeconds(1f);

        limits.max = 0;
        hinge.limits = limits;
    }

}
