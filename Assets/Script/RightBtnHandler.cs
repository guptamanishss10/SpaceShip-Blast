using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightBtnHandler : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerControler.left = false;
        PlayerControler.right = true;
    }

    // Start is called before the first frame update
    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerControler.right = false;
    }
}
