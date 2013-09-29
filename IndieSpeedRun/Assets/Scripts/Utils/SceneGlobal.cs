using UnityEngine;
using System.Collections;

public class SceneGlobal : MonoBehaviour {
//	public AudioClip splashScreen;
//	public AudioClip mainMenu;
//	public AudioClip inGameNight;
	public static AudioClip currentSceneMusic;
	
	static AudioClip previousTrack;
	void Awake ( ) {
		PlayerGlobals.GlobalVariables( );
		SceneGlobal.currentSceneMusic = audio.clip;
		InvokeRepeating("CheckMusicChange", 0.1f, 0.1f);
		DontDestroyOnLoad( this.gameObject );
	}
	
	public static void LoadSceneMusic(AudioClip trackToPlay)
	{
		SceneGlobal.currentSceneMusic = trackToPlay;
	}
	
	void CheckMusicChange()
	{
		if(SceneGlobal.currentSceneMusic == null)
			return;
		if(previousTrack == null)
		{
			ChangeMusic();
		}
		else if(previousTrack != SceneGlobal.currentSceneMusic){
			ChangeMusic();			
		}
	}
	
	void ChangeMusic()
	{
		audio.clip = SceneGlobal.currentSceneMusic;
		previousTrack = SceneGlobal.currentSceneMusic;
		audio.loop = true;
		Debug.Log("Now Playing Track: " + audio.clip.name.ToString());
		audio.Play();
		//TODO: Could add tween to fade in and out the music.
	}
	
}
