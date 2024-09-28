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
            // ������ ã�� ����
            _instance = FindObjectOfType<GameManager>();
        }

        // �׷����� ������
        if(_instance == null)
        {
            GameObject go = new GameObject("GameManager");
            _instance = go.AddComponent<GameManager>();
        }
        return _instance;
    }
 
    void Start()
    {
        Debug.Log(" ���� �ϴ°� Ȯ��");
        UIManager.Instance.CreatePage<UIStartPage>();
    }

    public void ChanegameScene()
    {
        // Scene ��ȯ.

        SceneManager.LoadScene("InGameScene");
        UIManager.Instance.RemovePage<UISelectMode>();
        CountTimer ui = UIManager.Instance.CreateGameUI<CountTimer>() as CountTimer;
        ui.SetGameTime(100);
    
    
    }

    private void Update()
    {
    }
}
