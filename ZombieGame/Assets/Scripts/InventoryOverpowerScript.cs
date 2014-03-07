﻿using UnityEngine;
using System.Collections;

public class InventoryOverpowerScript : MonoBehaviour {
	
	
	public GameInfoScript gis;
	// Use this for initialization
	void Start () {
		gis = (GameInfoScript)GameObject.Find("GameWorld").GetComponent<GameInfoScript>() as GameInfoScript;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (gis.powerUpActive)
				gis.switchPowerUpOff();
			
			GameObject.Destroy(this.gameObject);
			gis.overpowerActive = true;
			gis.powerUpActive = true;
			
		}
	}
}
