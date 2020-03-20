using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BattleController3 : MonoBehaviour  {
	public Text player1Text;
	public Text player2Text;



	int player1health = 100;
	int player2health = 100;

	bool player1Turn =true;
	int nerf = 2;
	[SerializeField] private string newlevel;
	// Use this for initialization
	void Start () 
	{
		Button btn_atk1 = gameObject.GetComponent<Button>();
		btn_atk1.onClick.AddListener(atack);

	}

	// Update is called once per frame
	void Update () {
		if (player1Turn)
		{
			if (nerf == 1) 

			{
				Player1Fight ();
				player1Turn = false;
				nerf = nerf + 1;
			}
		}
		if (this.player2health == 0) 
		{
			SceneManager.LoadScene(newlevel);
		}

	}
	public void atack()
	{
		this.player1Turn = true;
		this.nerf = 1;
	}


	void Player1Fight()
	{
		int damage = 100;
		player2health -= damage;
		if (player2health <= 0) 
		{
			player2health = 0;


		}
	}

}
