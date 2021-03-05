using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperTest : MonoBehaviour
{
    public GameObject ringGO;
    Collider ballCollider;
    void Start()
    {
        ringGO = GetComponentInParent<Ring>().gameObject;
        ballCollider = FindObjectOfType<Ball>().GetComponent<Collider>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other == ballCollider)
            ringGO.transform.localPosition = new Vector3(ringGO.transform.localPosition.x, ringGO.transform.localPosition.y-0.37f, ringGO.transform.localPosition.z);
         
    }
    void OnTriggerExit(Collider other)
    {
        if (other == ballCollider)
            ringGO.transform.localPosition = new Vector3(ringGO.transform.localPosition.x, ringGO.transform.localPosition.y + 0.37f, ringGO.transform.localPosition.z);
    }
}
