using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //            ↑ (0,0,1) 
        // (-1,0,0)←      →(1,0,0)
        //            ↓ (0,0,-1 * 3)

        // Horizontal : 수평에 대한 정보로 -1 ~ 1 사이의 값을 반환합니다.

        // Vertical : 수직에 대한 정보로 -1 ~ 1 사이의 값을 반환합니다.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);

        // 특정 방향을 매 프레임마다 이동하는 함수입니다.
        // normalizedf를 사용해서 단위 벡터를 만들어줍니다.
        // 벡터의 크기를 1로 만들어 줍니다.

        transform.Translate(dir.normalized * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3
                (
                   transform.position.x,
                   3,
                   transform.position.z
                );
        }
    }

    // 물리적인 충돌을 했을 때 동작하는 함수입니다.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }

    // 물리적인 충돌을 하고 있을 때 동작하는 함수입니다.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    // 물리적인 충돌을 벗어났을 때 동작하는 함수입니다.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }

    // 충돌 조건 
    // 2개의 오브젝트 중 하나는 RigidBody를 가지고 있어야 합니다.
    // 2개의 모두 Collider 컴포넌트를 가지고 있어야 합니다.

}
