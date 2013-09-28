using UnityEngine;
using System.Collections;

public class MessageBoxManager : MonoBehaviour {
	
	public UILabel text;
	public UISprite box;
	public UIFont font;
	
	public void setupMessageBox(MessageBox msgBox)
	{
		this.font = msgBox.font;
		this.box = msgBox.sprite;
	}
	
}
