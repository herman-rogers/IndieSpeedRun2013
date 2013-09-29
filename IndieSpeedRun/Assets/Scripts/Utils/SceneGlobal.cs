using UnityEngine;
using System.Collections;

public class SceneGlobal : MonoBehaviour {
	void Awake ( ) {
		PlayerGlobals.GlobalVariables( );
		DontDestroyOnLoad( this.gameObject );
	}
}
