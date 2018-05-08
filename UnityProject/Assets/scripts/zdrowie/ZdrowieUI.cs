using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZdrowieUI : MonoBehaviour {

	float maxZdrowie;
	float obecneZdrowie;
	public GUISkin skin;

	void Start () {
		maxZdrowie = 100;
		obecneZdrowie = 100;
	}

	void Update () {
		ognisko ();
	}

	void OnGUI() {
		GUI.Box (new Rect (50, Screen.height - 50, 150, 20), "Zdrowie: " + obecneZdrowie + "/" + maxZdrowie, skin.GetStyle("PasekZdrowia"));
	}

	public void ognisko() {
		if((transform.position.x > -6 && transform.position.y < 1) && (transform.position.x < 1 && transform.position.y > -5))
			obecneZdrowie = 100;
		else 
			obecneZdrowie -= Time.deltaTime / 3;
	}
}