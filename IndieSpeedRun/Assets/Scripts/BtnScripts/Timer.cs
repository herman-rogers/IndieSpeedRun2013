using UnityEngine;
using System;
using System.Collections;

public class Timer : MonoBehaviour {
	void Start( ){
		this.GetComponent< UILabel >( ).text = "Timer: " + 120;
		InvokeRepeating( "UpdateTimer", 0.01f, 1.0f );
	}
	void UpdateTimer( ){
		PlayerGlobals.playerTimer -= 1.0f;
		PlayerGlobals.GlobalVariables( );
		float minutes = Mathf.Floor( PlayerPrefs.GetFloat( "playerTimer" ) / 60 );
		float seconds = Mathf.RoundToInt( PlayerPrefs.GetFloat( "playerTimer" ) % 60 );
		this.GetComponent< UILabel >( ).text = ( minutes.ToString( "00" ) ) + ":" + ( seconds.ToString( "00" ) );
	}
}