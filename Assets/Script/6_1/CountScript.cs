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
            Debug.Log("스코어를 1점 추가합니다 [" + hit + "]");
        }

        if (collision.gameObject.tag != "Target")
        {
            if(hit <= 0)
            {
                Debug.Log("스코어가 0점이 되어 게임을 종료합니다.");
                transform.position = new Vector3(-11f,1f,-11f);
                hit = 3;
            }

            hit--;
            Debug.Log("스코어를 1점 감점합니다 [" + hit + "]");
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
