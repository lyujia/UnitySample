using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float minDistance = 3;
    [SerializeField]
    private float maxDistance = 30;
    [SerializeField]
    private float wheelSpeed = 500;
    [SerializeField]
    private float xMoveSpeed = 500;
    [SerializeField]
    private float yMoveSpeed = 250;
    private float yMinLimit = 5;
    private float yMaxLimit = 5;
    private float x, y;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        distance = Vector3.Distance(transform.position, target.position);
        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        if (Input.GetMouseButton(1))
        {
            x += Input.GetAxis("Mouse X") * xMoveSpeed * Time.deltaTime;
            y += Input.GetAxis("Mouse Y") * yMoveSpeed * Time.deltaTime;
            y = ClampAngle(y, yMinLimit, yMaxLimit);
            transform.rotation = Quaternion.Euler(y, x, 0);
        }
        distance -= Input.GetAxis("Mouse ScrollWheel") * wheelSpeed * Time.deltaTime;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

    }
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }

    private void LateUpdate()
    {
        if(target == null) return;

       transform.position = transform.rotation * new Vector3(0, 0, -distance) + target.position;
     }
}