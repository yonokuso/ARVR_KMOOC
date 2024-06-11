using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderLifeTime : MonoBehaviour
{
    public float LifeTime = 10f;
    public bool isColliderOn = false;
    public int cylinderNum = 1;


    private void OnCollisionStay(Collision collision)
    {        
        switch(collision.gameObject.tag)
        {
            case "Player":
                Debug.Log("Player");

                isColliderOn = true;

                float newX = collision.transform.position.x;
                float newZ = collision.transform.position.z;

                transform.position = new Vector3(newX, transform.position.y, newZ);
                // player, 그린 외의 콜라이더가 닿으면 destroy
                break;

            case "Blue":
                Debug.Log("Blue");
                // 
                break;

            case "Green":
                Debug.Log("Green");
                break;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isColliderOn)
        {
            LifeTime -= Time.deltaTime;
        }

        if (LifeTime < 0)
        {
            Destroy(gameObject);
        }

        if (isColliderOn)
        {
            LifeTime = 1;
        }
        
    }

}
