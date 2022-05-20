using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //            �� (0,0,1) 
        // (-1,0,0)��      ��(1,0,0)
        //            �� (0,0,-1 * 3)

        // Horizontal : ���� ���� ������ -1 ~ 1 ������ ���� ��ȯ�մϴ�.

        // Vertical : ������ ���� ������ -1 ~ 1 ������ ���� ��ȯ�մϴ�.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);

        // Ư�� ������ �� �����Ӹ��� �̵��ϴ� �Լ��Դϴ�.
        // normalizedf�� ����ؼ� ���� ���͸� ������ݴϴ�.
        // ������ ũ�⸦ 1�� ����� �ݴϴ�.

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

    // �������� �浹�� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }

    // �������� �浹�� �ϰ� ���� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    // �������� �浹�� ����� �� �����ϴ� �Լ��Դϴ�.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit");
    }

    // �浹 ���� 
    // 2���� ������Ʈ �� �ϳ��� RigidBody�� ������ �־�� �մϴ�.
    // 2���� ��� Collider ������Ʈ�� ������ �־�� �մϴ�.

}
