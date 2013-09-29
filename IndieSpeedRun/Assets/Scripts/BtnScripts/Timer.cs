using UnityEngine;
using System;
using System.Collections;

public class Timer : MonoBehaviour {
	public enum NightPhase{
		EARLY_NIGHT,
		MID_NIGHT,
		EARLY_HOURS,
		NEARLY_MORNING
	}
	public static NightPhase currentNightPhase = NightPhase.EARLY_NIGHT;
	void Start( ){
		InvokeRepeating( "UpdateTimer", 0.01f, 1.0f );
	}
	void UpdateTimer( ){
		PlayerGlobals.playerTimer -= 1.0f;
		PlayerGlobals.GlobalVariables( );
		float levelTimer = PlayerPrefs.GetFloat( "playerTimer" );
		float minutes = Mathf.Floor( levelTimer / 60 );
		float seconds = Mathf.RoundToInt( levelTimer % 60 );
		this.GetComponent< UILabel >( ).text = ( minutes.ToString( "00" ) ) + ":" + ( seconds.ToString( "00" ) );
		if( levelTimer > 0 && levelTimer < 40 )
			Timer.currentNightPhase = Timer.NightPhase.NEARLY_MORNING;
		else if( levelTimer >= 40 && levelTimer < 60 )
			Timer.currentNightPhase = Timer.NightPhase.EARLY_HOURS;
		else if( levelTimer >= 60 && levelTimer < 90 )
			Timer.currentNightPhase = Timer.NightPhase.MID_NIGHT;
		else if( levelTimer >= 90)
			Timer.currentNightPhase = Timer.NightPhase.EARLY_NIGHT;
		else if( levelTimer <= 0 )
			SceneFadeInOut.LoadLevel( "LevelWin", 0.03f, 0.03f, Color.magenta );
	}
}