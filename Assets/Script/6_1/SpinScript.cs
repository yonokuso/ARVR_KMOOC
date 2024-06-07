using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinScript : MonoBehaviour
{
    public float AngleX = 0;
    public float AngleY = 0;
    public float AngleZ = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(AngleX, AngleY, AngleZ);
    }
}
