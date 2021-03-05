using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour
{

    GameObject ballGO;
    GameObject bumperGO;
    GameObject slingShotGO;

    GameObject scoreGO;
    Text scoreText;

    GameObject ballsGO;
    Text ballsText;

        
    

    void Start()
    {
        ballGO = FindObjectOfType<Ball>().gameObject;
        bumperGO = FindObjectOfType<Ring>().gameObject;

        ballsGO = FindObjectOfType<Balls>().gameObject;
        ballsText = ballsGO.GetComponent<Text>();
      
        ballsText.text = 3.ToString();

        scoreGO = FindObjectOfType<Score>().gameObject;
        scoreText = scoreGO.GetComponent<Text>();

        scoreText.text = 0.ToString();
        
    }

   

    // Update is called once per frame
    void Update()
    {
        

    }
}
