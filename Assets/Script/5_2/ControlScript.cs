using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    // Array
    public GameObject[] Cameras;
    private int CameraNo = 0;

    void FocusCamera(int No)
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            Cameras[i].SetActive(i == No);
        }
    }

    void ChangeCamera(int direct)
    {
        CameraNo += direct;

        if (CameraNo >= Cameras.Length)
        {
            CameraNo = 0; // 0�� ī�޶�� �ǵ�����
        }
        if (CameraNo < 0)
        {
            CameraNo = Cameras.Length - 1; // ������ ī�޶�� �ǵ�����
        }
        FocusCamera(CameraNo);
    }

    void Start()
    {
        FocusCamera(CameraNo);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)) // 0==����
        {
            ChangeCamera(1);
        }
        if (Input.GetMouseButtonDown(1)) // 1==������
        {
            ChangeCamera(-1);
        }
    }
}
