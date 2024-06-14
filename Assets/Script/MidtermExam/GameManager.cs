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
    { // Update�� ���ѷ��� ��������!!!!!!!!!!

        PresentTime += Time.deltaTime;
        
        if (PresentTime >= PresentSpeed)
        {
            float newX = Random.Range(-7f, 7f);
            float newZ = Random.Range(-7f, 7f);

            GameObject Goalous = Instantiate(cylinder); // ����
            RandomTags(); // ���� �±�
            cylinder.transform.position = new Vector3(newX, 10, newZ);

            PresentTime = 0;
        }


    }

    void RandomTags() // �±׸� �����ϰ� ���� �Ǹ����� �±׸� ����
    {
        string[] tagList = { "Blue", "Green", "Yellow", "White", "Pink" };

        int randomNum = Random.Range(0, 5);

        string randomTag = tagList[randomNum];

        cylinder.transform.tag = randomTag;

    }


}
