using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    // [ ]  [ ]  [ ] 생성
    // ??   ??   ?? <- 파괴가 된 가비지 
    // 가비지 컬렉터라는 게 동작을 해서 일정 주기마다 해제를 합니다.

 
    void Start()
    {
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
