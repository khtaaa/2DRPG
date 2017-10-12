using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Fade_Out.fade_ok = true;
			Fade_Out.next="map";
			map_player.now=0;
			map_player.nonber = 0;
		}
	}
}
