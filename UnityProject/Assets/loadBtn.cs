using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class loadBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    public Text theText;
    // Use this for initialization
    public void doQuit()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = Color.white;
    }
}
