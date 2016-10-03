﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {


	private static GameManager _sharedInstance = null;

	public static GameManager sharedInstance{get { return _sharedInstance;}}


	public static Dictionary<string,string> characters  = new Dictionary<string,string>()
	{
		{"ryu"  , "fighterselect_0"},
		{"ehonda" , "fighterselect_1"},
		{"blanka" , "fighterselect_2"},
		{"guile" , "fighterselect_3"},
		{"ken" , "fighterselect_4"},
		{"chunli" , "fighterselect_5"},
		{"zangeif" , "fighterselect_6"},
		{"dhalsim" , "fighterselect_7"}
	};





	private string _character;
	public string character
	{
		get{ return _character; }
		set{ _character = value;  }
	}



	// Use this for initialization
	private void Awake () {
		
//		if (this != null && sharedInstance != this) {
//				Destroy (this.gameObject);
//		} else {
//			_sharedInstance = this;
//		}

		DontDestroyOnLoad (transform.gameObject);
		_sharedInstance = this;

	


	}

	void Start(){
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
