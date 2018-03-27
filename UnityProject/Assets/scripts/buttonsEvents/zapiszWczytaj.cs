using UnityEngine;
using System.Collections;

public class zapiszWczytaj : MonoBehaviour {

	public void zapisz() {

		PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", transform.position.y);

		PlayerPrefs.SetInt ("Random", Random.seed);
	}
		
	public void wczytaj() {

		float pX = PlayerPrefs.GetFloat ("PlayerX");
		float pY = PlayerPrefs.GetFloat ("PlayerY");

		transform.position = new Vector2 (pX, pY);

		Random.seed = PlayerPrefs.GetInt ("Random");

		MapGenerate _Map = new MapGenerate();
	}
}