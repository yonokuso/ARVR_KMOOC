using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCam : MonoBehaviour
{
    public Transform target; // position, rotate, scale ���� �������

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target); // LookAt - �Ѿư���
    }
}
