﻿using UnityEngine;
using System.Collections;

public class OverpowerScript : MonoBehaviour {
	
	
	//GameObject gameWorld;
	public GameInfoScript gis;
	
	// Use this for initialization
	void Start () {
		//gameWorld = GameObject.Find("GameWorld");
		gis = (GameInfoScript)GameObject.Find("GameWorld").GetComponent<GameInfoScript>() as GameInfoScript;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Q))
		{
			if (gis.overpowerActive)
				gis.powerUpTimer += gis.powerUpDuration;
			
			else
				gis.playerInventoryItem = (GameObject)Instantiate(Resources.Load("Icons/IconOverpower"), gis.inventorySlotLocation, transform.rotation);
			
			GameObject.Destroy(this.gameObject);
		}
	}
}
