using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    int hit = 3;
    float PresentTime = 0;
    public float AppearTime = 5f;
    public GameObject BallPrefab;

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
        PresentTime += Time.deltaTime;
        if(PresentTime > AppearTime)
        {
            float newX = Random.Range(-7f, 7f);
            float newY = Random.Range(7f, 12f);
            float newZ = Random.Range(-7f, 7f);


            GameObject Ball = Instantiate(BallPrefab);
            Ball.transform.position = new Vector3(newX,newY,newZ);

            PresentTime = 0;
        }
    }
}
