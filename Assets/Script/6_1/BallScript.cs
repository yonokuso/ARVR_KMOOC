using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float WaitTime = 2f;
    MeshRenderer Renderer; // 컴포넌트 변수화
    Rigidbody Rigid;

    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();
        Rigid = GetComponent<Rigidbody>();
        Renderer.enabled = false;
        Rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > WaitTime)
        {
            Renderer.enabled = true;
            Rigid.useGravity = true;


        }
    }
}
