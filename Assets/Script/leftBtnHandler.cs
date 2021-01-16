using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class leftBtnHandler : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerControler.left = true;
        PlayerControler.right = false;
    }

    // Start is called before the first frame update
    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerControler.left = false;
    }
}
