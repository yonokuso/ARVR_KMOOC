using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float BulletSpeed = 200f;
    public Vector3 ShootVector; // 방향값을 가짐
    public float Lifetime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(ShootVector * BulletSpeed);

        
    }

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;
        if (Lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
