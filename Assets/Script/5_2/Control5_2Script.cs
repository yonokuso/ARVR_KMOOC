using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control5_2Script : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ������ ����(�������� �����Ű�� ��ɾ�ȭ)
            GameObject BulletObject = Instantiate(BulletPrefab); // Instantiate - ������Ʈ�� �׼���
            
            // ��ũ��Ʈ ��������
            BulletScript bullet = BulletObject.GetComponent<BulletScript>();

            // �� ���Ͱ��� ��
            Vector3 ShootVector = new Vector3(
                Random.Range(-0.01f, 0.01f), 
                Random.Range(-0.01f, 0.01f), 
                1
                );
            // ���� ����ȭ(normalized)
            bullet.ShootVector = ShootVector.normalized;
        }
    }
}
