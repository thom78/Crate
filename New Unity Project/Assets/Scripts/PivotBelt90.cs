using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotBelt90 : MonoBehaviour {

    public PivotBelt pivotBelt;
    public Transform endpoint;
    public GameObject belt;
    public float speed;
    int interrupt = 1;
    float turnSpeed = -90.0f;


    public void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }

    public void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.transform != null )
                {
                    if (interrupt == 1)
                    {
                        //Debug.Log("interrupt " + interrupt);
                        hit.transform.Rotate(Vector3.up * turnSpeed);
                        interrupt = 0; 
                    }
                    else
                    {
                        //Debug.Log("interrupt " + interrupt);
                        hit.transform.Rotate(Vector3.up * -turnSpeed);
                        interrupt = 1;
                    }

                    
                }
        }

    }
}
