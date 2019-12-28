using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class projectile : MonoBehaviour {

	
	private Vector2 target;
	public float speed;
	public GameObject enemy;
	
	
	void Start () 
	{
        FindObjectOfType<AudioManager>().Play("shoot");
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);	
	
	}
	
	
	void Update () 
	{
		transform.position = Vector2.MoveTowards(transform.position,target,speed * Time.deltaTime);
		
		if(Vector2.Distance(transform.position,target) < 0.2f)
		{
			 
			//Instantiate(enemy,transform.position,Quternion.identity);
			Destroy(gameObject);
		}
	
	}
}
