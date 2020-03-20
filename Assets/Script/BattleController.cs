using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BattleController : MonoBehaviour  {
	public Text statusText;
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
				SwitchPlayers ();
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
	
	void StartPlayer1turn()
	{
		statusText.text = "Agora é o seu turno garoto escolha uma ação e me ataque!";
	}
	void Player1Fight()
	{
		int damage = Random.Range (25, 35);
		player2health -= damage;
		if (player2health <= 0) 
		{
			player2health = 0;


		}
	}
	void SwitchPlayers()
	{
		player1Text.text = "Health: " + player1health;
		player2Text.text = "Health: " + player2health;
		player1Turn = !player1Turn;
		if (player1Turn) 
		{
			StartPlayer1turn ();
		}
		else 
		{
			StartPlayer2turn ();
	
		}
	}


	void StartPlayer2turn()
	{
		statusText.text = "Muito bem garoto mas agora sou eu que ataco!";
		StartCoroutine (Player2Turn());

	}
	IEnumerator Player2Turn()
	{
		yield return new WaitForSeconds (2);
		Player2Fight ();
		SwitchPlayers ();

	}
	void Player2Fight ()
	{
		int damage = Random.Range (25, 35);
		player1health -= damage;
		if (player1health <= 0) 
		{
			player1health = 0;
		}
	}
}
