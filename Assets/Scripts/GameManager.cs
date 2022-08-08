using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text timeText;//생존 시간 표현할 텍스트 컴포넌트

    public GameObject gameOverUI;//게임오버 UI

    private float surviveTime;//생존 시간
    private bool isGameOver;//게임 오버 상태

    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = string.Format("Time: {0:0.00}", surviveTime);

        }
        else
        {
            if(Input.GetKey(KeyCode.R))
            {
                SceneControl.instance.Addtime(surviveTime);
                SceneControl.instance.LoadGameScene();
            }
            if (Input.GetKey(KeyCode.Q))
            {
                SceneControl.instance.GameQuit();
            }
        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }
}
