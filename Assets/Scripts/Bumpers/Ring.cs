using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring : MonoBehaviour
{
    GameObject ballGO;
    Collider ballCollider;

    public AudioClip bumperSound;
    AudioSource audioSource;

    private Text score;
    
    void Start()
    {
        ballGO = FindObjectOfType<Ball>().gameObject;
        ballCollider = ballGO.GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();

        score = FindObjectOfType<Score>().GetComponent<Text>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.collider == ballCollider)
        {
            score.text = (int.Parse(score.text)+100).ToString();
            audioSource.PlayOneShot(bumperSound, 0.3f);
        }
    }
    
    
}
