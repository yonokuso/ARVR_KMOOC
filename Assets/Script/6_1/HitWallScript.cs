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
        Debug.Log("¾Æ¾ß!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
