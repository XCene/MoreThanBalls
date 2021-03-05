using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDoorTrigger : MonoBehaviour
{
    public AudioClip skillSound;
    AudioSource audioSource;

    private Text score;
    private int extra;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = FindObjectOfType<Score>().GetComponent<Text>();
        
    }

    
    void OnTriggerEnter()
    {
        
        score.text = ((int.Parse(score.text) + 5000).ToString()); 
        audioSource.PlayOneShot(skillSound, 0.5f);
    }
}
