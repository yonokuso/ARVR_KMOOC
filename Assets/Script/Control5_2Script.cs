using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control5_2Script : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 변수의 변수(프리팹을 실행시키는 명령어화)
            GameObject BulletObject = Instantiate(BulletPrefab); // Instantiate - 오브젝트에 액세스
            
            // 스크립트 가져오기
            BulletScript bullet = BulletObject.GetComponent<BulletScript>();

            // 새 벡터값을 줌
            Vector3 ShootVector = new Vector3(
                Random.Range(-0.01f, 0.01f), 
                Random.Range(-0.01f, 0.01f), 
                1
                );
            // 벡터 정규화(normalized)
            bullet.ShootVector = ShootVector.normalized;
        }
    }
}
