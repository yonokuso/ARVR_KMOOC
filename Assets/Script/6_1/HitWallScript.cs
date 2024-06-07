using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Blue")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
