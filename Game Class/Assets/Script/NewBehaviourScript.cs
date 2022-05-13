using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Awake 함수는 Start 함수 이전에 한 번만 호출되는 함수입니다.
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }

    // Start 함수도 게임 시작할 때 한 번만 호출되는 함수입니다.
    void Start()
    {
        Debug.Log("Start 함수입니다.");

        // 자기 자신의 위치를 설정합니다.
        /*
        transform.position = new Vector3
        (
            transform.position.x,
            transform.position.y,
            transform.position.z + 1
        );
        */
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Update 함수입니다.");
        }
    }
}
