using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotBelt : MonoBehaviour
{

    public GameObject belt;
    public Transform endpoint;
    public float speed;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }

   
    public void OnMouseOver()
    {
        float turnSpeed = 45.0f;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                    if (hit.transform != null)
                    {
                        Debug.Log("Hit " + hit.transform.gameObject.name);
                        hit.transform.Rotate(Vector3.up * turnSpeed);
                    }
        }

    }
}
