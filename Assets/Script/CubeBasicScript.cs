using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class CubeBasicScript : MonoBehaviour
{
    public float SizeChanger = 2.5f;
    public string ChangeName = "goalous5";
    public bool isRotated = false;
    public float MoveSpeed = 1.0f;
    public float JumpPower = 200f;
    public bool JumpAvailable = false;
    public float RotateSpeed = 90f;

    string NameChange(string CubeName)
    {
        return "[[" + CubeName + "]]";
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Plane")
        {
            JumpAvailable = true;
        }
    }

    private void Start()
    {
        //transform.name = ChangeName;
        transform.name = NameChange(ChangeName);

        if (isRotated)
        {
            transform.localEulerAngles = Vector3.one * 45;
        }
        
    }

    private void Update()
    {
        transform.localScale = Vector3.one * SizeChanger;

        if (Input.GetKey("right"))
        {
            // 고사양게임 같은 60프레임을 넘어가면 계산방법이 달라져서
            // 움직이는 양을 고정하기위해 Time.deltaTime 붙임(시간보정역할)
            //transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            transform.RotateAround(transform.position, Vector3.up, RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            //transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
            transform.RotateAround(transform.position, Vector3.up, -RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("up"))
        {
            //transform.position += Vector3.forward * MoveSpeed * Time.deltaTime;
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position += Vector3.back * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown("space") && JumpAvailable)
        {
            GetComponent<Rigidbody>().AddForce(0,JumpPower,0);
            JumpAvailable = false;

        }


    }
}
