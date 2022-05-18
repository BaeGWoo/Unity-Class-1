using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
    public GameObject point;
    public float speed;

    void Update()
    {
        transform.position = Vector3.Lerp
            (
                transform.position,       // A 위치
                point.transform.position, // B 위치
                speed * Time.deltaTime  
            );
    }
}
