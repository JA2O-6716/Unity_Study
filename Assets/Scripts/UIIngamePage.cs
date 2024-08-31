using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; // 

public class UIIngamePage : MonoBehaviour
{
    [SerializeField] // 인스펙터에 표시해줘.
    private Button PlayButton;
    [SerializeField]
    private GameObject PlayerCard;
    [SerializeField]
    private GameObject CpuCard;
    [SerializeField]
    private GameObject GcwBottom;

    [SerializeField] 
    private Button Btn_G;
    [SerializeField]
    private Button Btn_C;
    [SerializeField]
    private Button Btn_W;

    [SerializeField]
    private UICard myCard;

    [SerializeField]
    private UICard cpuCard;

    private Canvas _canvas;

    public void SetCanvas(Canvas canvas)
    {
        _canvas = canvas;
    }

    // 만들어지고 최초 1회 불림 

    private void Start()
    {
        PlayButton.onClick.AddListener(OnClickPlay);
        Btn_G.onClick.AddListener(OnClickGCW_G);
        Btn_C.onClick.AddListener(OnClickGCW_C);
        Btn_W.onClick.AddListener(OnClickGCW_W);
    }

    private void SetActiveBottom()
    {
        Debug.Log("OnClickGCWs");

        PlayerCard.SetActive(true); // 
        CpuCard.SetActive(true); // 

        Btn_G.gameObject.SetActive(false);
        Btn_C.gameObject.SetActive(false);
        Btn_W.gameObject.SetActive(false);
        cpuCard.SetRandomGCW();
    }

    private void OnClickGCW_G()
    {
        SetActiveBottom();
        myCard.SetCardGCW(0);       
    }

    private void OnClickGCW_C()
    {
        SetActiveBottom();
        myCard.SetCardGCW(1);
    }

    private void OnClickGCW_W()
    {
        SetActiveBottom();
        myCard.SetCardGCW(2);


        /*GameManager gameManager = GameManager.GetInstance();
        Canvas canvas = gameManager.canva;*/

        //Debug.Log("캔버스 가지고옴 : " + canvas);

        GameObject uiPage = Resources.Load<GameObject>("Prefab/UIResultPage");

        Debug.Log(uiPage); // Null

        GameObject ui = Instantiate(uiPage);

        ui.transform.SetParent(_canvas.transform);
        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;
    }

    private float _accTime = 0;
    private int _waitTime = 5;
    private bool _isOver = false;

    private void Update()
    {
        _accTime += Time.deltaTime; 

        if(_accTime >= _waitTime && _isOver == false)
        {
            Debug.Log( "5초 지났음");
            _isOver = true;
        }
       
    }





    private void OnClickPlay()
    {
        Debug.Log("OnClickPlay 플레이 버튼이 눌림");

        GcwBottom.SetActive(true);
        PlayButton.gameObject.SetActive(false);
    }

  


}
