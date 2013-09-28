using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	void OnTriggerEnter( ){
		Debug.Log( tag );
		if ( tag == "Enemy" ){
			Debug.Log( "Enemy Damage" );
		}
	}
	void OnCollisionEnter( ){
		
		Debug.Log( "Collide?" );
		
	}
	
}
