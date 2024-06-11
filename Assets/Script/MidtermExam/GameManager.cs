using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cylinder;
    public float PresentTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { // Update에 무한루프 쓰지마셈!!!!!!!!!!

        PresentTime += Time.deltaTime;
        
        if (PresentTime >= 3)
        {
            float newX = Random.Range(-10f, 10f);
            float newZ = Random.Range(-10f, 10f);

            GameObject Goalous = Instantiate(cylinder);
            cylinder.transform.position = new Vector3(newX, 10, newZ);

            PresentTime = 0;
        }


    }


}
