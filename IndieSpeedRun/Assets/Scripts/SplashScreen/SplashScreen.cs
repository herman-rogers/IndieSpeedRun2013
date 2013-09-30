﻿using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	
	public float timeDisplayedFor = 5.0f;
	
	void Start()
	{
		Invoke("FinishSplash", timeDisplayedFor);	
	}
	void FinishSplash( ){
		SceneFadeInOut.LoadLevel( ( Application.loadedLevel + 1 ),  0.3f, 0.3f, new Color( 1.0f, ( 188f / 255f ), ( 11f / 255f ), 1.0f ) );
	}
}