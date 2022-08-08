using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;//생성한 탄알의 원본 프리펍 <- Drag & Drop을 할것이기에 public 설정
    private float spawnRateMin = 0.5f;//최초 생성 주기
    private float spawnRateMax = 3f;//최대 생성 주기

    private Transform target;//발사할 대상
    private float spawnRate;//생성 주기
    private float timeAfterSpawn;//최근 생성 시점에서 지난 시점



    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;//최근 생성 이후의 누적 시간을 0으로 초기화
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);//탄알 생성 간격을 Min에서 Max로 랜덤 설정
        // FindObjectOfType() 메서드는 씬에 존재하는 모든 오브젝트를 검색하여
        // 원하는 타입의 오브젝트를 찾아냄
        target = FindObjectOfType<PlayerController>().transform;
        //Update에서 쓰지 말기
        
    }

    // Update is called once per frame
    void Update()
    {

        // timeAfterSpawn 갱신
        // 이전 프레임과 현재 프레임 사이의 시간 간격을 더해줌
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;//최근 생성 이후의 누적 시간을 0으로 초기화
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);//bullet Prefab의 복제본을 transform.position 위치와 transform.rotation 회전으로 설정(bullet Spawner)
            bullet.transform.LookAt(target); //생성된 bullet게임 오브젝트의 정면 방향이 target을 향하도록 회전

            // 다음번 생성 간격을 spawnRateMin, spawnRateMax 사이에서 랜덤 지정
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        }

    }
}
