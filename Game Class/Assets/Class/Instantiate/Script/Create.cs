using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        // 게임 오브젝트를 3개 동시에 생성시킵니다.
        // x 축을 3의 배수로 띄워서 생성시켜야 합니다.

        
        // 생성할 게임 오브젝트, 위치, 회전
        // Quaternion.identity = 회전값을 0,0,0으로 초기화합니다.

        for(int i = 1; i <= 3; i++)
        {
            Instantiate(obj, new Vector3(3 * i, 0, 0), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
