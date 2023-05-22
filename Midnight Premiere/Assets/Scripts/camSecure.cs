using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSecure : MonoBehaviour
{
    public GameObject playerObj;
    public Transform camHeadTransform;
    public bool detected;
    public Vector3 offset;
    
    void Update()
    {
        Vector3 direction = playerObj.transform.position - camHeadTransform.position;
        RaycastHit hit;
        
        if (Physics.Raycast(camHeadTransform.position + offset, direction, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(camHeadTransform.position, hit.point, Color.red, Mathf.Infinity);

            if (hit.collider.gameObject == playerObj)
            {
                detected = true;
                Debug.Log("detected");
            }
            else
            {
                detected = false;
                Debug.Log("undetected");
            }
        }    
    }
}
