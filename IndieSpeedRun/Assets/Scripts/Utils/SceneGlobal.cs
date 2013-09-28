using UnityEngine;
using System.Collections;

public class SceneGlobal : MonoBehaviour {
	void Awake ( ) {
		DontDestroyOnLoad( this.gameObject );
	}
}
