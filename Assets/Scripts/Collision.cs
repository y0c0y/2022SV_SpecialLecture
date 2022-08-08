using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    /*
     
     */
    private void OnCollisionEnter(UnityEngine.Collision collision)//�浹�� �����ϴ� ����
    {
        Debug.Log("�浹 ����");//�ֿܼ� ���
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        /*
         �浹 ���۽� 
        �ڵ����� �����
        ���������̳� - ������ ���� ������Ʈ�� �������ڴٴ� ��, ������ �޽������� �����´ٴ� ��
        ������ ���� ���� �����ϰڴ�
        ��, �ڽ��� �浹�� �����ϴ� ���� Sphere�� ���� Green���� �ٲ��ְڴ�.
         
         */
    }
    private void OnCollisionExit(UnityEngine.Collision collision)// �浹�� ������ ����
    {
        Debug.Log("�浹 ��");
        collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        /*�浹 �� - �� �� RED*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("���� ����");//�ֿܼ� ���

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("���� ��");//�ֿܼ� ���

    }


}
