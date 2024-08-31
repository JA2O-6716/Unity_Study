using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        if(_instance == null)
        {
            _instance = FindObjectOfType<GameManager>();
        }

        return _instance;
    }


    public Canvas canva;


 
    void Start()
    {
        

        Debug.Log(" 시작 하는거 확인");
        CreateStartPage();
    }

    private void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.A))
        {
            // 이런것이 있는지 불러와본다.
            GameObject uiPage = Resources.Load<GameObject>("Prefab/UIResultPage");

            Debug.Log(uiPage); // Null

            GameObject ui = Instantiate(uiPage);

            ui.transform.SetParent(canva.transform);
            (ui.transform as RectTransform).offsetMin = Vector3.zero;
            (ui.transform as RectTransform).offsetMax = Vector3.zero;
        }*/

    }


    private void CreateStartPage()
    {
        // 이런것이 있는지 불러와본다.
        GameObject uiPage = Resources.Load<GameObject>("Prefab/UIStartPage");

        Debug.Log(uiPage); // Null

        GameObject ui = Instantiate(uiPage);

        ui.transform.SetParent(canva.transform);

        // 프로젝트마다 예외처리, 앵커처리를하기 위함
        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;

        UIStartPage comp = ui.GetComponent<UIStartPage>();
        comp.SetCanvas(canva);
    }

    
}
