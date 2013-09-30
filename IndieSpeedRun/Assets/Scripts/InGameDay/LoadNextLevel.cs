using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {
	void NextLevel( ){
		PlayerGlobals.currentLevel ++;
		Application.LoadLevel("NightScene " + PlayerGlobals.currentLevel);
	}
}
