using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

	  
	public GameObject shoot;
	private Transform playerPos;
	
	void Start () 
	{
		playerPos = GetComponent<Transform>();	
			
	}
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(shoot,playerPos.position,Quaternion.identity);
		}
	}
}
