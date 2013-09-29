﻿using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {
	void Start( ){
		this.GetComponent< UILabel >( ).text = "Spirits: " + 0;
		InvokeRepeating( "UpdatePoints", 0.01f, 0.009f );
	}
	void UpdatePoints( ){
		this.GetComponent< UILabel >( ).text = "Spirits: " + PlayerPrefs.GetFloat( "playerPoints" );
	}
}
