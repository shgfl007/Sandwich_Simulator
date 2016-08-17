using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public GameObject ing;
	private GameObject ing_copy;
	private float z;
	private GameObject Sbase;

	public void OnBeginDrag(PointerEventData eventdata){
		Debug.Log ("OnBeginDrag");

		//when start dragging this ingredient, instantiate the 3D version
		//align it with the base bread (having same z value)
		if (ing != null) {
			ing_copy = (GameObject) Instantiate (ing, eventdata.position, Quaternion.identity);
			ing_copy.tag="Topping";
			try{
				Sbase = GameObject.FindGameObjectWithTag("base");
				z = Sbase.transform.position.z;
			}catch{}
			Debug.Log (z.ToString ());
			//ing_copy.transform.position = eventdata.position;
		}
	}

	public void OnDrag(PointerEventData eventdata){
		Debug.Log ("OnDrag");
		//when dragging, make the 3D obj follow the mouse
		Vector3 pos = Public_Functions.ScreenPosToWorldPosByPlane(Input.mousePosition, new Plane(Vector3.forward, Vector3.zero));
		pos.z = z;
		ing_copy.transform.position = pos;
		Debug.Log (pos.ToString ());


	}

	public void OnEndDrag(PointerEventData eventdata){
		Debug.Log ("OnEndDrag");     
	}
}
