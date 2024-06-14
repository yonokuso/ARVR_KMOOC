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
        GameObject playerObj = GameObject.FindWithTag("Player"); // 하..........

        // 왜 collision이 아니라 player로 바꿨더라
        // collider 위아래로 다받으니까 player만 쏙 빠져버림
        // Player의 좌표를 어떻게 갖고오지........

        float newX = playerObj.transform.position.x;
        float newZ = playerObj.transform.position.z;

        switch (transform.tag) // 주체 실린더의 태그
        {
            case "Blue": // Cylinder color "Blue"
                switch (collision.gameObject.tag) // 닿은 실린더의 태그
                {
                    case "Player":
                    case "Green": // player, green과 닿았을 때
                       // Debug.Log("Blue 성공");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // 다른 색에 닿을 시 다시 시작
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Green":
                switch (collision.gameObject.tag) // 닿은 실린더의 태그
                {
                    case "Blue":
                    case "Yellow": // Blue, Yellow와  닿았을 때
                        //Debug.Log("Green 성공");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // 다른 색에 닿을 시 다시 시작
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Yellow":
                switch (collision.gameObject.tag) // 닿은 실린더의 태그
                {
                    case "Green":
                    case "White": // Green, White와  닿았을 때
                       // Debug.Log("Yellow 성공");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // 다른 색에 닿을 시 다시 시작
                        Destroy(gameObject);
                        break;
                }
                break;

            case "White":
                switch (collision.gameObject.tag) // 닿은 실린더의 태그
                {
                    case "Yellow":
                    case "Pink": // Yellow, Pink와  닿았을 때
                       // Debug.Log("White 성공");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        break;

                    default: // 다른 색에 닿을 시 다시 시작
                        Destroy(gameObject);
                        break;
                }
                break;

            case "Pink":
                switch (collision.gameObject.tag) // 닿은 실린더의 태그
                {
                    case "White": // White와  닿았을 때
                        //Debug.Log("Pink 성공, 점수 추가.");

                        transform.position = new Vector3(newX, transform.position.y, newZ);
                        // 이 사이에 텀을 두고 싶다
                        //Invoke("OnCollisionStay", 5f); // 안됨
                        //  yield return new WaitForSeconds(3f); //안됨
                        Destroy(collision.gameObject); // White 파괴, 순서대로 전부 파괴됨..

                        break;

                    case "Player":
                    case "Floor":
                        Destroy(gameObject);
                        break;

                }
                break;
        }
            
    }

    void SetColors() // 태그에 따른 색상 설정
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
