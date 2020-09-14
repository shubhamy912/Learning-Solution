using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_Movment : MonoBehaviour
{

    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;
    private float ZoomFactor = 1,flag=0, lerpSpeed = 10;

    private Vector3 previousPosition;
    private float campos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scrollData,change;
        scrollData = Input.GetAxis("Mouse ScrollWheel");

        if (scrollData != 0)
        {
            flag = 1;
        }

        
        change = ZoomFactor * scrollData;
        
       if (flag == 1)
         {
            cam.transform.Translate(new Vector3(0, 0, -change));
            distanceToTarget -= change;
            flag = 0;
            campos = distanceToTarget;

        }

      


        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically

             cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World);

            
            Debug.Log(distanceToTarget);
            cam.transform.Translate(new Vector3(0, 0, campos));
          //  cam.transform.Translate(campos);
            previousPosition = newPosition;
        }

        
    }
}

