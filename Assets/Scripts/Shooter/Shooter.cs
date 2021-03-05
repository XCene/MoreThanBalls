
using UnityEngine;

public class Shooter : MonoBehaviour
{


    public string inputName;

    FixedJoint shooter;

        
    // Start is called before the first frame update
    void Start()
    {
        shooter = GetComponent<FixedJoint>();
        shooter.massScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetAxis(inputName) == 1 && shooter.massScale > 0f)
        {
            shooter.massScale -= 0.1f;
        }
        else if(Input.GetAxis(inputName) == 1 && shooter.massScale <= 0f)
        {
                shooter.massScale = 0f;
            }
        else if (Input.GetAxis(inputName) == 0)
        {
            shooter.massScale = 1f;
        }

    }

    
}
