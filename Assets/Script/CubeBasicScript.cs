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

    string NameChange(string CubeName)
    {
        return "[[" + CubeName + "]]";
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
            // ������� ���� 60�������� �Ѿ�� ������� �޶�����
            // �����̴� ���� �����ϱ����� Time.deltaTime ����(�ð���������)
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("up"))
        {
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime;
        }

    }
}
