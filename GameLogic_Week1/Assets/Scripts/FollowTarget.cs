using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    public Transform targetObject;
    public Camera MyCam;

    private void Update()
    {
        Debug.LogFormat("My Target X: {0} and Y: {1}", transform.position.x, transform.position.y);

        transform.position = MyCam.WorldToScreenPoint(targetObject.position);
        
    }

}
