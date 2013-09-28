using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject monster;
	public float spawnRate;
	float timer = 0;
	void Awake ( ){
		InvokeRepeating( "StartSpawn", 0.01f, Random.Range( 1.0f, 5.0f ) );
		Random.Range( 2.0f, 5.0f);
	}
	void StartSpawn( ){
		NGUITools.AddChild( this.gameObject , monster );
		if ( timer >= 5.0f  ){
			CancelInvoke( );
			InvokeRepeating( "MidnightSpawn", 0.01f, Random.Range( 0.01f, 1.0f ) );
			return;
		}
		timer += 1f;
	}
	void MidnightSpawn( ){
		NGUITools.AddChild( this.gameObject , monster );
		if ( timer > 10.0f && timer <= 15f){
			CancelInvoke( );
			InvokeRepeating( "MorningSpawn", 0.01f, Random.Range( 1.0f, 5.0f ) );
			return;
		}
		timer += 1f;
	}
	void MorningSpawn( ){
		NGUITools.AddChild( this.gameObject , monster );
		timer += 1f;
	}
}
