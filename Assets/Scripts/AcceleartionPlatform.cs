using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleartionPlatform : MonoBehaviour
{
    [SerializeField]
    private float accelForce;
    [SerializeField]
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<Movement3D>().MoveTo(direction, accelForce);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
