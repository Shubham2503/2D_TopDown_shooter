using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {
	
	public float speed;
	private Transform playerPos;	
	private player player;
	public GameObject effect;
	
	
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
		
		playerPos = GameObject.FindGameObjectWithTag("Player").transform;
		
	}
	
	void Update () 
	{
		transform.position = Vector2.MoveTowards(transform.position,playerPos.position,speed * Time.deltaTime); 	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
		Instantiate(effect,transform.position,Quaternion.identity);
		player.health--;
        FindObjectOfType<AudioManager>().Play("coll");
        Debug.Log(player.health);
		Destroy(gameObject);
		}
		
		if(other.CompareTag("projectile"))
		{
			Instantiate(effect,transform.position,Quaternion.identity);
			player.score++;
            FindObjectOfType<AudioManager>().Play("coll");
            Destroy(other.gameObject);
			Destroy(gameObject);
		}
	} 
		
}
