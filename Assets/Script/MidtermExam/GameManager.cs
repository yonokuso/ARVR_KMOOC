using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cylinder;
    public float PresentTime = 0;
    public float PresentSpeed = 2;
    
    // Update is called once per frame
    void Update()
    { // Update에 무한루프 쓰지마셈!!!!!!!!!!

        PresentTime += Time.deltaTime;
        
        if (PresentTime >= PresentSpeed)
        {
            float newX = Random.Range(-7f, 7f);
            float newZ = Random.Range(-7f, 7f);

            GameObject Goalous = Instantiate(cylinder); // 생성
            RandomTags(); // 랜덤 태그
            cylinder.transform.position = new Vector3(newX, 10, newZ);

            PresentTime = 0;
        }


    }

    void RandomTags() // 태그를 랜덤하게 고르고 실린더의 태그를 변경
    {
        string[] tagList = { "Blue", "Green", "Yellow", "White", "Pink" };

        int randomNum = Random.Range(0, 5);

        string randomTag = tagList[randomNum];

        cylinder.transform.tag = randomTag;

    }


}
