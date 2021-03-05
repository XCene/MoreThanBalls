using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightSlingshot : MonoBehaviour
{
    GameObject ballGO;
    GameObject slingGO;

    public AudioClip contactSound;
    AudioSource audioSource;

 private Text score;
    void Start()
    {
        ballGO = FindObjectOfType<Ball>().gameObject;
        slingGO = FindObjectOfType<RightSlingshot>().gameObject;

        audioSource = GetComponent<AudioSource>();
        score = FindObjectOfType<Score>().GetComponent<Text>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == ballGO)
        {
            slingGO.transform.localPosition = new Vector3(slingGO.transform.localPosition.x - 0.3f, slingGO.transform.localPosition.y, slingGO.transform.localPosition.z);
            audioSource.PlayOneShot(contactSound, 0.3f);
            score.text = (int.Parse(score.text) + 50).ToString();
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject == ballGO)
        {
            slingGO.transform.localPosition = new Vector3(slingGO.transform.localPosition.x + 0.3f, slingGO.transform.localPosition.y, slingGO.transform.localPosition.z);


        }
    }

}
