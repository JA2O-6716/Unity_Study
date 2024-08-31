using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class TestImage : MonoBehaviour , IPointerClickHandler, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag가 되었음");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("버튼이 눌렸음");
    }
}
