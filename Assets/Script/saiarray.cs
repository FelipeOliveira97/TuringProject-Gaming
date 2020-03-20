using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saiarray : MonoBehaviour {

	[SerializeField] private string newlevel;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (drag.locked && drag2.locked && drag3.locked) 
		{
			SceneManager.LoadScene(newlevel);
		}
	}
}
