using UnityEngine;
using System.Collections;

public class MessageCreater : MonoBehaviour {
	
	public UIFont font;
	public UISprite sprite;
	public string messageText;
	
	GameObject msg;
	
	void CreateMessage()
	{
		if(!msg && PlayerGlobals.isDay)
		{
			msg = DialogueSystem.GetInstance.CreateMessageBox(
				new MessageBox(font, sprite), this.gameObject);
			UILabel msgText = msg.GetComponentInChildren<UILabel>();
			sprite = this.GetComponentInChildren<UISprite>();
			msgText.text = messageText;
			
			msgText.lineWidth = (int)(sprite.transform.localScale.x - 20.0f);
			msgText.maxLineCount = Mathf.FloorToInt (sprite.transform.localScale.y / msgText.transform.localScale.y);
			msgText.shrinkToFit = true;
		}
	}
	
}
