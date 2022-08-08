using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public static SceneControl instance;

    private float totaltime = 0f;
    
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void Addtime(float time)
    {
        totaltime += time;
        Debug.Log(totaltime);
    }
    
}
