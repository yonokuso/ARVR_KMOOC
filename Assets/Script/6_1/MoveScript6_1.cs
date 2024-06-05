using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript6_1 : MonoBehaviour
{
    public float PlayerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * PlayerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * PlayerSpeed;

        transform.Translate(xValue, 0 , zValue); // Translate?
    }
}
