using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float delta;
    // Start is called before the first frame update
    void Start()
    {
        delta = 0.1f;   
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newPosition, transform.localPosition.y, transform.localPosition.z);
        if(transform.localPosition.x < -5)
        {
            delta = 0.1f;
        }
        else if(transform.localPosition.x >5)
        {
            delta = -0.1f;
        }
    }
}
