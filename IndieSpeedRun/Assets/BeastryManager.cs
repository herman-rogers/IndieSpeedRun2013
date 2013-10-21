using UnityEngine;
using System.Collections;

public class BeastryManager : MonoBehaviour {
	
	public string[] name;
	public string[] descriptions;
	public string[] imageName;
	
	public UILabel title;
	public UILabel description;
	public UISprite monsterImage;	
	
	int currentPos = 0;
	int max;
	void Start()
	{
		max = Mathf.Min(imageName.Length, Mathf.Min(descriptions.Length, name.Length));
		LoadSelection();
	}	
	
	public void OnMoveForward()
	{
		if(currentPos >= max - 1)
			return;
		currentPos ++;
		LoadSelection();
	}
	
	public void OnMoveBackward()
	{
		if(currentPos <= 0)
			return;
		currentPos --;
		LoadSelection();
	}
	
	void LoadSelection()
	{
		title.text = name[currentPos];
		description.text = descriptions[currentPos];
		monsterImage.spriteName = imageName[currentPos];
		monsterImage.MakePixelPerfect();
	}
}
