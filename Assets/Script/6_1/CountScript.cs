using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    int hit = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hit++;
        Debug.Log("¹ú½á " + hit + "¹øÀÌ³ª ºÎµúÇûÀÝ¾Æ!");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
