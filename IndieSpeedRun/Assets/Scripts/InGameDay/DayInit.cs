using UnityEngine;
using System.Collections;

public class DayInit : MonoBehaviour {

	void Start()
	{
		PlayerGlobals.isDay = true;
		Destroy(this);
	}
	
}
