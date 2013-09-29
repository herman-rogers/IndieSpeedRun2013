using UnityEngine;
using System.Collections;

public class PlayerGlobals : MonoBehaviour {	
	public static float playerPoints = 0;
	public static void GlobalVariables ( ) {
		PlayerPrefs.SetFloat( "playerPoints", playerPoints );
	}
}
