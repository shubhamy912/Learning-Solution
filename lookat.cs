using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    Transform cam;
    Vector3 targetAngle = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        
       
        transform.localEulerAngles = targetAngle;
    }
}
