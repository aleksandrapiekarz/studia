using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class doExit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {


    public Text theText;
	// Use this for initialization
	public void doQuit(){
		Debug.Log("has quit game");
		Application.Quit ();
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = Color.black;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = Color.white;
    }
}
