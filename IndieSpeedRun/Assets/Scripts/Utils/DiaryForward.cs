using UnityEngine;
using System.Collections;

public class DiaryForward : MonoBehaviour {
	void OnClick( ){
			Application.LoadLevel( Application.loadedLevel + 1 );
	}
}
