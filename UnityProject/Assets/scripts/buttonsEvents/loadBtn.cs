using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text theText;

	public float pX, pY;

    public void doLoad()
	{
		Random.seed = PlayerPrefs.GetInt ("Random");
		//MapGenerate _Map = new MapGenerate();

		pX = PlayerPrefs.GetFloat ("PlayerX");
		pY = PlayerPrefs.GetFloat ("PlayerY");
		transform.position = new Vector2 (pX, pY);

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
