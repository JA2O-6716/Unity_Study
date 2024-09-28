using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIStartPage : UIBase
{
    private Canvas _canvas;

    public void SetCanvas(Canvas canvas)
    {
        _canvas = canvas;
    }

    private Button _startButton;

    void Start()
    {
        Button startButton = GetComponentInChildren<Button>();                                                                   
        startButton.onClick.AddListener(GameStart);
    }   

    public void GameStart()
    {
        UIManager.Instance.CreatePage<UISelectMode>();
        UIManager.Instance.RemovePage<UIStartPage>();
    }

}
