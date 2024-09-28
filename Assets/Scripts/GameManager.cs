using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        if(_instance == null)
        {
            // 씬에서 찾아 보자
            _instance = FindObjectOfType<GameManager>();
        }

        // 그런데도 없으면
        if(_instance == null)
        {
            GameObject go = new GameObject("GameManager");
            _instance = go.AddComponent<GameManager>();
        }
        return _instance;
    }
 
    void Start()
    {
        Debug.Log(" 시작 하는거 확인");
        UIManager.Instance.CreatePage<UIStartPage>();
    }

    public void ChanegameScene()
    {
        // Scene 전환.

        SceneManager.LoadScene("InGameScene");
        UIManager.Instance.RemovePage<UISelectMode>();
        CountTimer ui = UIManager.Instance.CreateGameUI<CountTimer>() as CountTimer;
        ui.SetGameTime(100);
    
    
    }

    private void Update()
    {
    }
}
