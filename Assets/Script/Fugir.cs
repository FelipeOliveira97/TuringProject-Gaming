using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fugir : MonoBehaviour {
	[SerializeField] private string newlevel;

	void Start () 
	{
		
		Button btn_fugir = gameObject.GetComponent<Button>();
		btn_fugir.onClick.AddListener(fugir);

	}
	void fugir()
	{
		SceneManager.LoadScene (newlevel);
	}
	
}