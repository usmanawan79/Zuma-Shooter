using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 11;
    private float lowerBound = -11;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.x > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.x < lowerBound)
        {
            gameObject.SetActive(false);
        }

    }
}
