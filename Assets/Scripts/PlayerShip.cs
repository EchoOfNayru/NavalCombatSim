using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
          
            Vector3 currentForward = transform.forward;

            ////go forwards
            transform.position += transform.forward * 10;

            ////turn left
            currentForward = Quaternion.AngleAxis(-90, Vector3.up) * transform.forward;
            transform.forward = currentForward;

            //go forwards
            transform.position += transform.forward * 10;
        }
        if (Input.GetKeyDown("right"))
        {

            Vector3 currentForward = transform.forward;

            ////go forwards
            transform.position += transform.forward * 10;

            ////turn left
            currentForward = Quaternion.AngleAxis(90, Vector3.up) * transform.forward;
            transform.forward = currentForward;

            //go forwards
            transform.position += transform.forward * 10;
        }
        if (Input.GetKeyDown("up"))
        {
            transform.position += transform.forward * 10;
        }

        Debug.DrawLine(transform.position, transform.position + (transform.forward * 10), Color.green);
    }
}
