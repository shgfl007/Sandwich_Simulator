using UnityEngine;
using System.Collections;

public class exit_click : MonoBehaviour {

	public void ExitGame(){
		Debug.Log ("exit game");
		Application.Quit ();
	}
}
