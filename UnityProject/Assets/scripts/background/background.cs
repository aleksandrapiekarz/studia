using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

	public Transform background1;
	public Transform background2;

	private bool Whichone =true;
	public Transform cam;
	private float currentheight=36;
	// Update is called once per frame
	void Update () {


		if (currentheight < cam.position.y) {

			if (Whichone)
				background1.localPosition = new Vector3 (0, background1.localPosition.y + 72, 10);
			else
				background2.localPosition =new Vector3 (0, background2.localPosition.y + 72, 10);
		

			currentheight += 36;
			Whichone = !Whichone;
		
		}
		if (currentheight > cam.position.y+36) {

			if (Whichone)
				background2.localPosition = new Vector3 (0, background2.localPosition.y - 72, 10);
			else
				background1.localPosition = new Vector3 (0, background1.localPosition.y - 72, 10);


			currentheight -= 36;
			Whichone = !Whichone;

		}
	}
}
