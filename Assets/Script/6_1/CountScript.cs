using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    int hit = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            hit++;
            Debug.Log("���ھ 1�� �߰��մϴ� [" + hit + "]");
        }

        if (collision.gameObject.tag != "Target")
        {
            if(hit <= 0)
            {
                Debug.Log("���ھ 0���� �Ǿ� ������ �����մϴ�.");
                transform.position = new Vector3(-11f,1f,-11f);
                hit = 3;
            }

            hit--;
            Debug.Log("���ھ 1�� �����մϴ� [" + hit + "]");
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
