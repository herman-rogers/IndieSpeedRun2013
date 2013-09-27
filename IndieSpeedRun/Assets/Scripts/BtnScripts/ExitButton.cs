using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour{
	public GameObject parentObject;
	void OnClick( ){
		Destroy( parentObject );
	}
	
}
