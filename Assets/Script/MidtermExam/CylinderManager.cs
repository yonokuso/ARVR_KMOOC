using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{
    MeshRenderer mr;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void OnCollisionStay(Collision collision)
    {
        GameObject playerObj = GameObject.FindWithTag("Player"); // ��..........

        // �� collision�� �ƴ϶� player�� �ٲ����
        // collider ���Ʒ��� �ٹ����ϱ� player�� �� ��������
        // Player�� ��ǥ�� ��� �������........

        float newX = playerObj.transform.position.x;
        float newZ = playerObj.transform.position.z;

        switch (transform.tag) // ��ü �Ǹ����� �±�
        {
            case "Blue": // Cylinder color "Blue"
                switch (collision.gameObject.tag) // ���� �Ǹ����� �±�
                {
                    case "Player":
                    case "Green": // player, green�� ����� ��
                       // Debug.Log("Blue ����");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // �ٸ� ���� ���� �� �ٽ� ����
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Green":
                switch (collision.gameObject.tag) // ���� �Ǹ����� �±�
                {
                    case "Blue":
                    case "Yellow": // Blue, Yellow��  ����� ��
                        //Debug.Log("Green ����");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // �ٸ� ���� ���� �� �ٽ� ����
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Yellow":
                switch (collision.gameObject.tag) // ���� �Ǹ����� �±�
                {
                    case "Green":
                    case "White": // Green, White��  ����� ��
                       // Debug.Log("Yellow ����");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // �ٸ� ���� ���� �� �ٽ� ����
                        Destroy(gameObject);
                        break;
                }
                break;

            case "White":
                switch (collision.gameObject.tag) // ���� �Ǹ����� �±�
                {
                    case "Yellow":
                    case "Pink": // Yellow, Pink��  ����� ��
                       // Debug.Log("White ����");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // �ٸ� ���� ���� �� �ٽ� ����
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Pink":
                switch (collision.gameObject.tag) // ���� �Ǹ����� �±�
                {
                    case "White": // White��  ����� ��
                        //Debug.Log("Pink ����, ���� �߰�.");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        // �� ���̿� ���� �ΰ� �ʹ�
                        //Invoke("OnCollisionStay", 5f); // �ȵ�
                        //  yield return new WaitForSeconds(3f); //�ȵ�
                        Destroy(collision.gameObject); // White �ı�, ������� ���� �ı���..

                        break;

                    case "Player":
                    case "Floor":
                        Destroy(gameObject);
                        break;

                }
                break;
        }
            
    }

    void SetColors() // �±׿� ���� ���� ����
    {
        if (transform.tag == "Blue")
        {
            mr.material.color = Color.blue;

        }

        if (transform.tag == "Green")
        {
            mr.material.color = Color.green;

        }

        if (transform.tag == "Yellow")
        {
            mr.material.color = Color.yellow;

        }

        if (transform.tag == "White")
        {
            mr.material.color = Color.white;

        }

        if (transform.tag == "Pink")
        {
            mr.material.color = Color.magenta;

        }

    }

    private void Update()
    {
        SetColors();
    }



}
