using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyTimer : MonoBehaviour {

	public float myCoolTimer;
	public Text timerText;
	[SerializeField] private string newlevel;
	void Start () {
		timerText = GetComponent<Text> ();	
	}
	
	// Update is called one per frame
	void Update () {
		myCoolTimer -= Time.deltaTime;
		timerText.text = myCoolTimer.ToString ("f1");
		print (myCoolTimer);
		if (myCoolTimer <= 0) 
		{
			myCoolTimer = 0;
		}
		if (myCoolTimer == 0) 
		{
			
			SceneManager.LoadScene(newlevel);
		}
		
	}
}
