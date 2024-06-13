using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{    
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
                        Debug.Log("Blue ����");

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
                        Debug.Log("Green ����");

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
                        Debug.Log("Yellow ����");

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
                        Debug.Log("White ����");

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
                        Debug.Log("Pink ����, ���� �߰�.");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        // �� ���̿� ���� �ΰ� �ʹ�
                        Destroy(collision.gameObject); // White �ı�, ������� ���� �ı���..

                        break;
                }
                break;
        }
            
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    

}
