using UnityEngine;
using System.Collections;

public class EnemyDamagePlayer : MonoBehaviour {
	void OnTriggerEnter( ){
		Destroy( this.gameObject );
	}
}
