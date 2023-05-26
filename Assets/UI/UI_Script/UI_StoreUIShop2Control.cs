using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_StoreUIShop2Control : MonoBehaviour {
	public GameObject UI_StoreUICoin;
	public GameObject UI_StoreUIChangeModelPanel;
	public GameObject UI_StoreUIChangeModelModelName;

	public GameObject v1s;
	public GameObject v2s;
	public GameObject v3s;
	public GameObject v4s;
	public GameObject v5s;
	public GameObject v6s;
	public GameObject v7s;
	public GameObject v8s;
	public GameObject v9s;
	public GameObject v10s;

	int i;
	int Coin;
	void Start () {
		for (i = 1; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("v" + i) == false)
				PlayerPrefs.SetInt ("v" + i, 0);
		}

		#region For SoldOutItem
		if (PlayerPrefs.GetInt ("v1") == 1)
			v1s.SetActive(true);
		if (PlayerPrefs.GetInt ("v2") == 1)
			v2s.SetActive(true);
		if (PlayerPrefs.GetInt ("v3") == 1)
			v3s.SetActive(true);
		if (PlayerPrefs.GetInt ("v4") == 1)
			v4s.SetActive(true);
		if (PlayerPrefs.GetInt ("v5") == 1)
			v5s.SetActive(true);
		if (PlayerPrefs.GetInt ("v6") == 1)
			v6s.SetActive(true);
		if (PlayerPrefs.GetInt ("v7") == 1)
			v7s.SetActive(true);
		if (PlayerPrefs.GetInt ("v8") == 1)
			v8s.SetActive(true);
		if (PlayerPrefs.GetInt ("v9") == 1)
			v9s.SetActive(true);
		if (PlayerPrefs.GetInt ("v10") == 1)
			v10s.SetActive(true);
		#endregion
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region For ShopBtOnClick
	public void v1 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v1s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v1", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v2 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v2s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v2", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v3 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v3s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v3", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v4 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v4s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v4", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v5 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v5s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v5", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v6 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v6s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v6", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v7 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v7s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v7", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v8 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v8s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v8", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v9 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v9s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v9", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void v10 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			v10s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("v10", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	#endregion

	public static string UI_Store_ChangeItemName;
	public void SoldOutOnClick(Button btName){
		UI_StoreUIShop1Control.StoreNum =2;
		UI_StoreUIChangeModelPanel.SetActive (true);
		UI_Store_ChangeItemName = btName.name;
		UI_StoreUIChangeModelModelName.GetComponent<Text> ().text = "" + FindModelName(UI_Store_ChangeItemName);
	}

	public string FindModelName(string btName){
		string ItemName = "";
		switch (btName) {
		case "v1":
			ItemName = "Original Ball";
			break;
		case "v2":
			ItemName = "Bowlingball";
			break;
		case "v3":
			ItemName = "Delicious Watermelon";
			break;
		case "v4":
			ItemName = "VolleyBall";
			break;
		case "v5":
			ItemName = "Tennis";
			break;
		case "v6":
			ItemName = "Soccer";
			break;
		case "v7":
			ItemName = "Pokemon Ball";
			break;
		case "v8":
			ItemName = "Dice";
			break;
		case "v9":
			ItemName = "Basketball";
			break;
		case "v10":
			ItemName = "Football";
			break;
		default:
			break;
		}
		return ItemName;
	}
}
