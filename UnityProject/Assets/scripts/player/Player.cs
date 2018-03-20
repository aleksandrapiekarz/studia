﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private MainPlayer _Player = new MainPlayer();
	private Animator animator;
	protected Vector2 direction;
	float speed = 5f;

	void Start () {
		
		animator = GetComponent<Animator>();
	}

	void Update () {
		
		Move ();
		GetInput ();
	}

	private void GetInput() {

		direction = Vector2.zero;

		if (Input.GetKey (KeyCode.W)) {
			direction += Vector2.up;
		}
		if (Input.GetKey (KeyCode.A)) {
			direction += Vector2.left;
		}
		if (Input.GetKey (KeyCode.S)) {
			direction += Vector2.down;
		}
		if (Input.GetKey (KeyCode.D)) {
			direction += Vector2.right;
		}
	}

	public void Move() {
		
		transform.Translate (direction * speed * Time.deltaTime);

		AnimateMovement (direction);
	}

	public void AnimateMovement(Vector2 direction) {

		animator.SetFloat ("x", direction.x);
		animator.SetFloat ("y", direction.y);
	}
}
