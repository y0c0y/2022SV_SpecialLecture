using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;//������ ź���� ���� ������ <- Drag & Drop�� �Ұ��̱⿡ public ����
    private float spawnRateMin = 0.5f;//���� ���� �ֱ�
    private float spawnRateMax = 3f;//�ִ� ���� �ֱ�

    private Transform target;//�߻��� ���
    private float spawnRate;//���� �ֱ�
    private float timeAfterSpawn;//�ֱ� ���� �������� ���� ����



    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;//�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);//ź�� ���� ������ Min���� Max�� ���� ����
        // FindObjectOfType() �޼���� ���� �����ϴ� ��� ������Ʈ�� �˻��Ͽ�
        // ���ϴ� Ÿ���� ������Ʈ�� ã�Ƴ�
        target = FindObjectOfType<PlayerController>().transform;
        //Update���� ���� ����
        
    }

    // Update is called once per frame
    void Update()
    {

        // timeAfterSpawn ����
        // ���� �����Ӱ� ���� ������ ������ �ð� ������ ������
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;//�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);//bullet Prefab�� �������� transform.position ��ġ�� transform.rotation ȸ������ ����(bullet Spawner)
            bullet.transform.LookAt(target); //������ bullet���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��

            // ������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        }

    }
}
