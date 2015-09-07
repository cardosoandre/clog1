﻿using UnityEngine;
using System.Collections;

public class DontStopTheMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private static DontStopTheMusic _instance ;
	
	void Awake()
	{
		//if we don't have an [_instance] set yet
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject) ;
		
		
		DontDestroyOnLoad(this.gameObject) ;
	}
}
