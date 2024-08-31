using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICard : MonoBehaviour
{
    [SerializeField]
    private Text _gcwText;

    // index = 0 가위 , 1 바위, 2 보
    public void SetCardGCW(int index)
    {
        switch(index)
        {
            case 0:
                _gcwText.text = "가위";
                break;
            case 1:
                _gcwText.text = "바위";
                break;
            case 2:
                _gcwText.text = "보";
                break;
        }
    }

    public void SetRandomGCW()
    {
        int random = Random.Range(0,3);
        SetCardGCW(random);
    }

    
}
