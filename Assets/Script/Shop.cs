using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop :MonoBehaviour
{
	float moneyAmount;
	int isRifleSold;
	int isRifle2Sold;
	int isRifle3Sold;
	int isRifle4Sold;

	public Text moneyAmountText;
	public Text item1price;
	public Text item2price;
	public Text item3price;
	public Text item4price;
	public Button buyButton;
	public Button buyButton2;
	public Button buyButton3;
	public Button buyButton4;
	[SerializeField] private string newlevel;

	void Start()
	{
		moneyAmount =220.68f;
	}
	void Update ()
	{
		moneyAmountText.text = "Money: " + moneyAmount.ToString () + "$";
		isRifleSold = PlayerPrefs.GetInt ("isRifleSold");
		isRifle2Sold = PlayerPrefs.GetInt ("isRifle2Sold");
		isRifle3Sold = PlayerPrefs.GetInt ("isRifle3Sold");
		isRifle4Sold = PlayerPrefs.GetInt ("isRifle4Sold");
		if (moneyAmount <= 0) 
		{
			moneyAmountText.text = "0";
			SceneManager.LoadScene(newlevel);
		}

	}
	public void buyRifle()
	{
		moneyAmount -= 23.4f;
		PlayerPrefs.SetFloat ("IsRifleSold", 1);
		item1price.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}
	public void buyRifle2()
	{
		moneyAmount -= 55.69f;
		PlayerPrefs.SetFloat ("IsRifle2Sold", 1);
		item2price.text = "Sold!";
		buyButton2.gameObject.SetActive (false);
	}	
	public void buyRifle3()
	{
		moneyAmount -= 75.6f;
		PlayerPrefs.SetFloat ("IsRifle3Sold", 1);
		item3price.text = "Sold!";
		buyButton3.gameObject.SetActive (false);
	}	
	public void buyRifle4()
	{
		moneyAmount -= 65.99f;
		PlayerPrefs.SetFloat ("IsRifle4Sold", 1);
		item4price.text = "Sold!";
		buyButton4.gameObject.SetActive (false);
	}
}