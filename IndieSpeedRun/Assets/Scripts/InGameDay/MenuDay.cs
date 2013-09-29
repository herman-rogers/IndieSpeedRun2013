using UnityEngine;
using System.Collections;

public class MenuDay : MonoBehaviour {
	
	public GameObject menu;
	bool menuOpen = false;
	
	void OnMenuClicked()
	{
		menuOpen = !menuOpen;
		NGUITools.SetActive(menu, menuOpen);
		TweenAlpha tweenA = menu.GetComponent<TweenAlpha>();
		tweenA.Play(menuOpen);
		tweenA.enabled = true;
	}
	
}
