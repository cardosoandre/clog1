﻿using UnityEngine;
using System.Collections;

public class MudarCordeLuz : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		gameObject.GetComponent<Light> ().enabled = false;
	}
}
