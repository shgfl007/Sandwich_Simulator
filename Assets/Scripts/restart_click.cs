using UnityEngine;
using System.Collections;

public class restart_click : MonoBehaviour {
	private GameObject[] toppings;

	//destroy the top bread and toppings to restart
	public void reStart(){
		toppings = GameObject.FindGameObjectsWithTag ("Topping");
		for (int i = 0; i < toppings.Length; i++) {
			Destroy (toppings[i]);
		}

		GameObject top;
		top = GameObject.FindGameObjectWithTag ("top");
		if (top != null)
			Destroy (top);
	}
}
