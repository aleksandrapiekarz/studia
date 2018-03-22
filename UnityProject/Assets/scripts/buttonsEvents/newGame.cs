using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newGame : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text theText;

    public void doNewGame()
    {
		SceneManager.LoadScene("mainScene");

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
