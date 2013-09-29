using UnityEngine;
using System.Collections;

public class LoadMusicOnStart : MonoBehaviour {
	
	public AudioClip sceneMusic;
	
	// Use this for initialization
	void Start () {
		if(sceneMusic != null)
			SceneGlobal.LoadSceneMusic(sceneMusic);
		else
		{
			Debug.LogError("Scene's Music either null or not loaded correctly!");
		}
		Destroy(this);
	}

}
