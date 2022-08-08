using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /*
     
     */
    private void OnCollisionEnter(UnityEngine.Collision collision)//충돌이 시작하는 순간
    {
        Debug.Log("충돌 시작");//콘솔에 출력
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        /*
         충돌 시작시 
        자동으로 담아짐
        정보컨테이너 - 상대방의 게임 오브젝트를 가져오겠다는 뜻, 상대방의 메쉬렌더를 가져온다는 것
        상대방의 색을 직접 수정하겠다
        즉, 박스가 충돌을 감지하는 순간 Sphere의 색을 Green으로 바꿔주겠다.
         
         */
    }
    private void OnCollisionExit(UnityEngine.Collision collision)// 충돌이 끝나는 순간
    {
        Debug.Log("충돌 끝");
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        /*충돌 끝 - 공 색 RED*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("감지 시작");//콘솔에 출력

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("감지 끝");//콘솔에 출력

    }


}
