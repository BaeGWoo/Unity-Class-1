using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    Animator animator;
    public GameObject window;

    void Start()
    {
        animator = window.GetComponent<Animator>();
    }

    void Update()
    {
       // 애니메이터 컨트롤러에서 현재 애니메이터 상태의 이름이 "Close" 일 때
       if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
       {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 UI를 비활성화하도록 설정합니다.
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                window.SetActive(false);
            }
       }
    }

    public void Open()
    {
        window.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
   

}
