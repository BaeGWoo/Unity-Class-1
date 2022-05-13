using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Awake �Լ��� Start �Լ� ������ �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");
    }

    // Start �Լ��� ���� ������ �� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    void Start()
    {
        Debug.Log("Start �Լ��Դϴ�.");

        // �ڱ� �ڽ��� ��ġ�� �����մϴ�.
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
            Debug.Log("Update �Լ��Դϴ�.");
        }
    }
}