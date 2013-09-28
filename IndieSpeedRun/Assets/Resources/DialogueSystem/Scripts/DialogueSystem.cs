using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour {
	
	//Public variables.
	
	public UIFont Arial;
	public GameObject defaultMessageBox;
	
	
	
	//Private variables.
	
	/// <summary>
	/// The font that will be used when a message box is created.
	/// </summary>
	UIFont usedFont;
	
	private static DialogueSystem Instance;
	const string prefabLocation = "DialogueSystem/DialogueSystem";
	
	public static DialogueSystem GetInstance
	{
        get
        {			
			if(Instance == null)
			{
				GameObject singleton = (GameObject)Resources.Load(prefabLocation, typeof(GameObject));
				if(!singleton)
					Debug.LogError("DialogueSystem prefabLocation incorrect: Resource/" + prefabLocation);
				else
					Instance = (DialogueSystem)(((GameObject)Instantiate(singleton)).GetComponent<DialogueSystem>());
			}
			return Instance;
		}
	}

	public GameObject GetMessageBox(MessageBox msgBox)
	{
		defaultMessageBox.GetComponent<MessageBoxManager>().setupMessageBox(msgBox);
		return defaultMessageBox;
		
	}
	
	public GameObject GetDefaultMessageBox()
	{
		return defaultMessageBox;
	}
	
	public GameObject CreateMessageBox(MessageBox msgBox, GameObject parent)
	{
		GameObject msgBoxGO = NGUITools.AddChild(parent, defaultMessageBox);
		msgBoxGO.GetComponent<MessageBoxManager>().setupMessageBox(msgBox);
		return msgBoxGO;
		
	}
	
	public GameObject CreateDefaultMessageBox(GameObject parent)
	{
		return NGUITools.AddChild(parent, defaultMessageBox);
	}
	
	
//	public 
}

public class MessageBox
{
	public Color fontColour;
	public UIFont font = DialogueSystem.GetInstance.Arial;
	//		public 
	//	public UIAtlas defaultAtlas;
	//		public string spriteName;	
}

public static class Colours
{
	public static Color red = new Color(1f, 0f, 0f, 1f);
	
}
