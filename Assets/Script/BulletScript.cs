using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float BulletSpeed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * BulletSpeed);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
