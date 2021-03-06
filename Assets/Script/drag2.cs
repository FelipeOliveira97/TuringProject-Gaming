﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag2 : MonoBehaviour {

	[SerializeField]
	private Transform bunnyPlace;
	private Vector2 initialPosition;
	private Vector2 mousePosition;
	private float deltaX, deltaY;
	public static bool locked;
	void Start () {
		initialPosition = transform.position;
	}
	private void OnMouseDown()
	{
		if (!locked) 
		{
			deltaX = Camera.main.ScreenToWorldPoint (Input.mousePosition).x - transform.position.x;
			deltaY = Camera.main.ScreenToWorldPoint (Input.mousePosition).y - transform.position.y;
		}

	}
	private void OnMouseDrag()
	{
		if (!locked) 
		{
			mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			transform.position = new Vector2 (mousePosition.x - deltaX, mousePosition.y - deltaY);

		}
			
		
	}
	private void OnMouseUp()
	{
		if (Mathf.Abs (transform.position.x - bunnyPlace.position.x) <= 0.5f && Mathf.Abs (transform.position.y - bunnyPlace.position.y) <= 0.5f) 
		{
			transform.position = new Vector2 (bunnyPlace.position.x, bunnyPlace.position.y);
			locked = true;
			Destroy (gameObject);
		}
		else
		{
			transform.position = new Vector2 (initialPosition.x, initialPosition.y);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
