using UnityEngine;
using System.Collections;

public class DayInit : MonoBehaviour {
	public GameObject doorOpen;
	public GameObject doorClosed;
	public GameObject windowOpen;
	public GameObject windowClosed;
	public GameObject lampBroken;
	public GameObject lampFixed;
	public GameObject radiator;
	public GameObject pictureNormal;
	public GameObject pictureChanged;
	
	public GameObject room;
	public bool cheat;
	void Start()
	{
		if(room == null)
			room = this.gameObject;
		//DOOR
		if(cheat)//if( PlayerGlobals.isDoorOpen )
			NGUITools.AddChild(room, doorOpen);
		else
			NGUITools.AddChild(room, doorClosed);
		//WINDOW
		if(cheat)//if( PlayerGlobals.isWindowOpen )
			NGUITools.AddChild(room, windowOpen);
		else
			NGUITools.AddChild(room, windowClosed);
		//LAMP
		if(cheat)//if( PlayerGlobals.isLampOn )
			NGUITools.AddChild(room, lampFixed);
		else
			NGUITools.AddChild(room, lampBroken);
		//PICTURE
		if(cheat)//if( PlayerGlobals.isPictureChanged )
			NGUITools.AddChild(room, pictureChanged);
		else
			NGUITools.AddChild(room, pictureNormal);
		//RADIATOR	
		if(cheat)//if( PlayerGlobals.isRadiatorOn )
			NGUITools.AddChild(room, radiator);
		
		PlayerGlobals.isDay = true;
		Destroy( this );
	}
	
}
