using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    // 스페이스를 눌렀을 때 속도가 10 증가하도록 설정합니다.
    // 그리고 속도가 100이상 넘어가게 되면 다시 0으로 설정합니다.

    public GameObject origin;
    public float speed;

    void Update()
    {
        if(speed >= 100)
        {
            speed = 0;
        }

        transform.RotateAround(origin.transform.position, Vector3.down, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }

        
    }
}
