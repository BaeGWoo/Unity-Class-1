using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    // �����̽��� ������ �� �ӵ��� 10 �����ϵ��� �����մϴ�.
    // �׸��� �ӵ��� 100�̻� �Ѿ�� �Ǹ� �ٽ� 0���� �����մϴ�.

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
