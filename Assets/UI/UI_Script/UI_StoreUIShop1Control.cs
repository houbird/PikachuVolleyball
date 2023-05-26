using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_StoreUIShop1Control : MonoBehaviour {
	public GameObject UI_StoreUICoin;
	public GameObject UI_StoreUIChangeModelPanel;
	public GameObject UI_StoreUIChangeModelModelName;


	public GameObject p1s;
	public GameObject p2s;
	public GameObject p3s;
	public GameObject p4s;
	public GameObject p5s;
	public GameObject p6s;
	public GameObject p7s;
	public GameObject p8s;
	public GameObject p9s;
	public GameObject p10s;

	int i;
	int Coin;
	void Start () {
		for (i = 1; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("p" + i) == false)
				PlayerPrefs.SetInt ("p" + i, 0);
		}

		#region For SoldOutItem
		if (PlayerPrefs.GetInt ("p1") == 1)
			p1s.SetActive(true);
		if (PlayerPrefs.GetInt ("p2") == 1)
			p2s.SetActive(true);
		if (PlayerPrefs.GetInt ("p3") == 1)
			p3s.SetActive(true);
		if (PlayerPrefs.GetInt ("p4") == 1)
			p4s.SetActive(true);
		if (PlayerPrefs.GetInt ("p5") == 1)
			p5s.SetActive(true);
		if (PlayerPrefs.GetInt ("p6") == 1)
			p6s.SetActive(true);
		if (PlayerPrefs.GetInt ("p7") == 1)
			p7s.SetActive(true);
		if (PlayerPrefs.GetInt ("p8") == 1)
			p8s.SetActive(true);
		if (PlayerPrefs.GetInt ("p9") == 1)
			p9s.SetActive(true);
		if (PlayerPrefs.GetInt ("p10") == 1)
			p10s.SetActive(true);
		#endregion
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region For ShopBtOnClick
	public void p1 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p1s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p1", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p2 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p2s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p2", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p3 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p3s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p3", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p4 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p4s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p4", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p5 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p5s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p5", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p6 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p6s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p6", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p7 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p7s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p7", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p8 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p8s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p8", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p9 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p9s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p9", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	public void p10 (){
		Coin = PlayerPrefs.GetInt ("Coin");
		if (Coin >= 25) {
			p10s.SetActive(true);
			PlayerPrefs.SetInt ("Coin",Coin-25);
			PlayerPrefs.SetInt ("p10", 1);
			UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		}
	}
	#endregion

	public static string UI_Store_ChangeItemName;
	public static int StoreNum=0; //storeNum=1<-pikaSkin storeNum=2<-vball
	public void SoldOutOnClick(Button btName){
		UI_StoreUIShop1Control.StoreNum = 1;
		UI_StoreUIChangeModelPanel.SetActive (true);
		UI_Store_ChangeItemName = btName.name;
		UI_StoreUIChangeModelModelName.GetComponent<Text> ().text = "" + FindModelName(UI_Store_ChangeItemName);
	}
		
	public string FindModelName(string btName){
		string ItemName = "";
		switch (btName) {
		case "p1":
			ItemName = "empty";
			break;
		case "p2":
			ItemName = "Cowboy Hat";
			break;
		case "p3":
			ItemName = "Black SunGlasses";
			break;
		case "p4":
			ItemName = "Red SunGlasses";
			break;
		case "p5":
			ItemName = "Headphone";
			break;
		case "p6":
			ItemName = "Magician Hat";
			break;
		case "p7":
			ItemName = "Wristband";
			break;
		case "p8":
			ItemName = "Basketball Cap";
			break;
		case "p9":
			ItemName = "Straw Hat";
			break;
		case "p10":
			ItemName = "Skateboard";
			break;
		default:
			break;
		}
		return ItemName;
	}

}
