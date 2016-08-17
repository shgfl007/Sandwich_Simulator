using UnityEngine;
using System.Collections;

public class Public_Functions : MonoBehaviour {

	public static Vector3 ScreenPosToWorldPosByPlane(Vector2 screenPos, Plane plane){
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (screenPos.x, screenPos.y, 1f));
		float distance;
		if (!plane.Raycast (ray, out distance))
			throw new UnityException ("didnot hit the plane");
		return ray.GetPoint (distance);
	}
		
}
