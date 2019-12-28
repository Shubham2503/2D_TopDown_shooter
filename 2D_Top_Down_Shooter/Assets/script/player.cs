using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour {


	public float speed;
	public int health = 10;
	public int score = 0;
   
	public Text healthDisplay;
	public Text scoreDisplay;
		
	private Rigidbody2D rb;
	private Vector2 moveVelocity;
	

	void Start ()
        {
		rb = GetComponent<Rigidbody2D>();
		
        
	}

	void Update ()
        {
		healthDisplay.text = "HEALTH : " + health;
		scoreDisplay.text = "score : " + score;   
		if(health <= 0)
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		
		Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput.normalized * speed;
	}

	void FixedUpdate()
	{
        PlayerPrefs.SetInt("NetScore", score);
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        rb.MovePosition(rb.position + moveVelocity*Time.fixedDeltaTime);
	}	
}
