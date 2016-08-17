using UnityEngine;
using System.Collections;

public class Done_click : MonoBehaviour {
	private GameObject[] toppings;
	private float y = 0;
	private float offset = 0;
	private Vector3 pos;


	public GameObject bread;

	//function to add the last bread
	public void Add_bread(){
		//find the base bread object
		GameObject basebread = GameObject.FindGameObjectWithTag("base");

		//find all the toppings 
		toppings = GameObject.FindGameObjectsWithTag ("Topping");

		//get the y value to put the top bread
		if (toppings.Length == 0) {
			y = basebread.transform.position.y + basebread.GetComponent<Collider> ().bounds.size.y;
		} else {
			//get the highest y position
			for (int i = 0; i < toppings.Length; i++) {
				if (y < toppings [i].transform.position.y) {
					y = toppings [i].transform.position.y;
					offset = toppings [i].GetComponent<Collider> ().bounds.size.y / 2;
				}
			
			}
			y = y + basebread.GetComponent<Collider> ().bounds.size.y / 2 + offset;

		}

		//align the top one with the bottum one
		pos = new Vector3 (basebread.transform.position.x, y, basebread.transform.position.z);
		GameObject top_ins = (GameObject)Instantiate (bread, pos, Quaternion.identity);
		//set tag value for restarting
		top_ins.tag = "top";

		//reset y
		y = 0;
	}
}
