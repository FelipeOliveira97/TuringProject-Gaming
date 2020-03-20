using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mudar : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Button btn_muda = gameObject.GetComponent<Button>();
		btn_muda.onClick.AddListener(muda);
		
	}
	
	// Update is called once per frame
	public void muda()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
