﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name_text : MonoBehaviour {
	public Image image;
	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text=image.GetComponent<status> ().name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
