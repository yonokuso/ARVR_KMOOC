using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript6_1 : MonoBehaviour
{
    public float PlayerSpeed = 5f;

    // Start is called before the first frame update
    void StartMessage()
    {
        Debug.Log("Sir-! GOALOUS!");
    }

    void Start()
    {
        StartMessage();
    }

    void PlayerMove()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * PlayerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * PlayerSpeed;

        transform.Translate(xValue, 0, zValue); // Translate?
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
