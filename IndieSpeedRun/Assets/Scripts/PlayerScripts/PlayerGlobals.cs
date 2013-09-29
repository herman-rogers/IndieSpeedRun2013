using UnityEngine;
using System.Collections;

public static class PlayerGlobals{	
	public static float playerPoints = 0;
	public static bool isDay{set; get;}
	public static void GlobalVariables ( ) {
		PlayerPrefs.SetFloat( "playerPoints", playerPoints );
	}
}
