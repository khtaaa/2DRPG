﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear_manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel ("title");//シーン切り替え
		}
	}
}
