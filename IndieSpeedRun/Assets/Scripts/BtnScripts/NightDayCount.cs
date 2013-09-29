using UnityEngine;
using System.Collections;

public class NightDayCount : MonoBehaviour {
	void Update( ){
		Time.timeScale = 0;
		Debug.Log( gameObject.GetComponent< UISprite >( ).alpha );
		if (gameObject.GetComponent< UISprite >( ).alpha <= 0 ){
			Time.timeScale = 1;
		}
	}
}
