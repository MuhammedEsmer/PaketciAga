using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followThisObhect;
   [SerializeField] int offset = 10;


    void  LateUpdate()
    {
       transform.position = followThisObhect.transform.position + new Vector3 (0,0, -offset);
    }
}
