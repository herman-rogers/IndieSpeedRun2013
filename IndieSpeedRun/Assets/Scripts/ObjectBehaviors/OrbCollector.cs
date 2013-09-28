using UnityEngine;
using System.Collections;

public class OrbCollector : MonoBehaviour {
	// This script can be placed on an 2D object
	//to give it simple AI that moves
	//it towards a player character
	//-- perfect for orb collection/Simple Enemies
	public float movementSpeed 	= 10;
	public float rotationSpeed 	= 5;
	public bool enemyAI	   		= false;
	Transform  target;
	void Start ( ) {
		target = GameObject.FindWithTag( "Player" ).transform; // can replace this with an event system
															  //Preferably with an OnCollisionEnter - type
		if ( enemyAI ){
			InvokeRepeating( "Animate2DEnemy", 0.01f, 0.009f );
			return;
		}
		InvokeRepeating( "AnimateOrb", 0.01f, 0.009f );
	}
	void AnimateOrb( ) {
		transform.rotation = Quaternion.Slerp( transform.rotation,
		Quaternion.LookRotation( target.position - transform.position ), ( rotationSpeed * Time.deltaTime) );
		transform.position += ( transform.forward * movementSpeed * Time.deltaTime );
	}
	void Animate2DEnemy( ){
		movementSpeed += 0.001f;
		transform.position = Vector3.MoveTowards( transform.position, target.transform.position , movementSpeed * Time.deltaTime );
	}
}
