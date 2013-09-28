using UnityEngine;
using System.Collections;

public class EnemyDestroyClick : MonoBehaviour {
	public GameObject parent;
	void OnClick ( ) {
		Destroy( this.gameObject );
		Destroy( parent.gameObject );
	}
}
