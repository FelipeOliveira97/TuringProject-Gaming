using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public PlayerController player;
	private Vector3 lastposition;
	private float distanciaX,distanciaY;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		lastposition = player.transform.position;
	}

	// Update is called once per frame
	void Update () {
		distanciaX = player.transform.position.x - lastposition.x;
		distanciaY = player.transform.position.y - lastposition.y;
		transform.position = new Vector3 (transform.position.x + distanciaX, transform.position.y+distanciaY,transform.position.z);

		lastposition = player.transform.position;

	}
}