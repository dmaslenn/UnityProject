﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbittosha : MonoBehaviour {

	public float speed = 1;
	Rigidbody2D myBody = null;

	void Start () {
			myBody = GetComponent <Rigidbody2D> ();	
	}

	void FixedUpdate () {
			float value = Input.GetAxis ("Horizontal");
			if (Mathf.Abs(value) > 0){
				Vector2 vel = myBody.velocity;
				vel.x = value * speed;
				myBody.velocity = vel;
			}	

			SpriteRenderer sr = GetComponent <SpriteRenderer> ();
			if(value < 0) {
				sr.flipX = true;
			}	else if(value > 0){
				sr.flipX = false;
			}
	}
}
