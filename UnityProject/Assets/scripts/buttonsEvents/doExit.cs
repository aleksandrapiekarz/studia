using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doExit : MonoBehaviour {

	// Use this for initialization
	public void doQuit(){
		Debug.Log("has quit game");
		Application.Quit ();
	}


}
