﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	
	public GameObject enemy;
	public Transform[] spawnSpots;
	private float timeBtwSpawns;
	public float startTimeBtwSpawns;

	
	void Start () 
	{
		timeBtwSpawns = startTimeBtwSpawns;
	}
	

	void Update () 
	{
		if(timeBtwSpawns <= 0)
		{
			int randPos = Random.Range(0,spawnSpots.Length);
			Instantiate(enemy,spawnSpots[randPos].position,Quaternion.identity);
			timeBtwSpawns = startTimeBtwSpawns;
		}
		
		else
		{
			timeBtwSpawns -= Time.deltaTime;
		}
	}
}
