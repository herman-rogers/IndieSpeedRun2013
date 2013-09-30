using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour {
	
	public Texture2D cursor;
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void OnGUI () {
		Screen.showCursor = false;
		Vector3 mousePos = Input.mousePosition;
		Rect pos = new Rect(mousePos.x - cursor.width/4, (Screen.height - mousePos.y)- cursor.height/4, cursor.width/2, cursor.height/2);
		GUI.Label(pos, cursor);
	}
}
