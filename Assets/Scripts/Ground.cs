using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    float zRotation;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
      zRotation = transform.localEulerAngles.z;
        Debug.Log(Input.mousePosition);
        if(Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                transform.localEulerAngles = new Vector3(0, 0, zRotation + 1);
            }
            else
            {
                transform.localEulerAngles = new Vector3(0, 0, zRotation - 1);
            }
        }
    }
}
