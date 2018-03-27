using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text theText;
    
    public void doLoad()
	{
		float pX = PlayerPrefs.GetFloat ("PlayerX");
		float pY = PlayerPrefs.GetFloat ("PlayerY");
		transform.position = new Vector2 (pX, pY);

		Random.seed = PlayerPrefs.GetInt ("Random");
		MapGenerate _Map = new MapGenerate();

		SceneManager.LoadScene("mainScene");
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
