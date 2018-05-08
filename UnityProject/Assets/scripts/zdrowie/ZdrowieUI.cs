using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZdrowieUI : MonoBehaviour {

	float maxZdrowie;
	float obecneZdrowie;
	float zdrowie;
	public GUISkin skin;


	void Start () {
		maxZdrowie = 100;
		obecneZdrowie = 100;
		zdrowie = 100;
	}

	void Update () {
		ognisko ();
	}

	void OnGUI() {
		GUI.Box (new Rect (50, Screen.height - 50, 150, 20), "Zdrowie: " + obecneZdrowie + "/" + maxZdrowie, skin.GetStyle("PasekZdrowia"));
	}

	public void ognisko() {
		if ((transform.position.x > -6 && transform.position.y < 1) && (transform.position.x < 1 && transform.position.y > -5) ||
		    (transform.position.x > -40 && transform.position.y < -19) && (transform.position.x < -30 && transform.position.y > -29) ||
		    (transform.position.x > 8 && transform.position.y < -31) && (transform.position.x < 18 && transform.position.y > -41) ||
		    (transform.position.x > 38 && transform.position.y < 3) && (transform.position.x < 48 && transform.position.y > -7) ||
		    (transform.position.x > 20 && transform.position.y < 36) && (transform.position.x < 30 && transform.position.y > 26) ||
		    (transform.position.x > -25 && transform.position.y < 41) && (transform.position.x < -15 && transform.position.y > 31) ||
		    (transform.position.x > -58 && transform.position.y < 13) && (transform.position.x < -48 && transform.position.y > 3)) {

			if (obecneZdrowie < 100) {
				zdrowie += Time.deltaTime;
				obecneZdrowie = Mathf.Round (zdrowie);
			}
		} else {
			zdrowie -= Time.deltaTime / 3;
			obecneZdrowie = Mathf.Round (zdrowie);
		}
	}
}