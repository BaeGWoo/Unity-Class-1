using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavControll : MonoBehaviour
{
    public float speed;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 발사를 했을 때 콜라이더를 감지합니다.
             
            // 광선에 대한 정보(ray), 광선과 충돌한 오브젝트의 정보(hit), 광선의 발사 거리(Mathf.Infinity)
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }      
    }

    public void Move(Vector3 direction)
    {
        agent.speed = speed;

        // SetDestination( ) : 선택한 방향의 정보가 저장되며, 선택되어 있는 방향 정보로 이동하는 함수입니다.
        agent.SetDestination(direction);
    }
}
