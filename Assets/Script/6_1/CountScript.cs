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
        Debug.Log("���� " + hit + "���̳� �ε����ݾ�!");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
