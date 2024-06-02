using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCam : MonoBehaviour
{
    public Transform target; // position, rotate, scale 전부 들어있음

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target); // LookAt - 쫓아가라
    }
}
