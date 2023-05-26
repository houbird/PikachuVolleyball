using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_StoreUIControl : MonoBehaviour {
	public GameObject UI_StoreUICanvas;
	public GameObject UI_StoreUICoin;

	#region GameObject P and V;
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject p5;
	public GameObject p6;
	public GameObject p7;
	public GameObject p8;
	public GameObject p9;
	public GameObject p10;
	public GameObject v1;
	public GameObject v2;
	public GameObject v3;
	public GameObject v4;
	public GameObject v5;
	public GameObject v6;
	public GameObject v7;
	public GameObject v8;
	public GameObject v9;
	public GameObject v10;
	#endregion

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("Coin")==false){
			PlayerPrefs.SetInt("Coin", 0);
		}

		UI_StoreUICanvas.GetComponent<Animation> ().Play ("UI_StoreUI_FadeIn");
		UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");

		UI_Store_EquipShowP ();
		UI_Store_EquipShowV ();
		System.GC.Collect ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public static void RefreshP(){
		for (int i = 1; i <= 10; i++) {
			PlayerPrefs.SetInt ("p" + i + "e", 0);
		}
	}

	public static void RefreshV(){
		for (int i = 1; i <= 10; i++) {
			PlayerPrefs.SetInt ("v" + i + "e", 0);
		}
	}

	public void UI_Store_EquipShowP(){
		#region For DelAllItemOutline
		p1.GetComponent<Outline>().enabled = false;
		p2.GetComponent<Outline>().enabled = false;
		p3.GetComponent<Outline>().enabled = false;
		p4.GetComponent<Outline>().enabled = false;
		p5.GetComponent<Outline>().enabled = false;
		p6.GetComponent<Outline>().enabled = false;
		p7.GetComponent<Outline>().enabled = false;
		p8.GetComponent<Outline>().enabled = false;
		p9.GetComponent<Outline>().enabled = false;
		p10.GetComponent<Outline>().enabled = false;
		#endregion

		#region For SetEquipItemOutline
		if (PlayerPrefs.GetInt ("p1e") == 1)
			p1.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p2e") == 1)
			p2.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p3e") == 1)
			p3.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p4e") == 1)
			p4.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p5e") == 1)
			p5.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p6e") == 1)
			p6.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p7e") == 1)
			p7.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p8e") == 1)
			p8.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p9e") == 1)
			p9.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("p10e") == 1)
			p10.GetComponent<Outline>().enabled = true;
		#endregion
	}

	public void UI_Store_EquipShowV(){
		#region For DelAllItemOutline
		v1.GetComponent<Outline>().enabled = false;
		v2.GetComponent<Outline>().enabled = false;
		v3.GetComponent<Outline>().enabled = false;
		v4.GetComponent<Outline>().enabled = false;
		v5.GetComponent<Outline>().enabled = false;
		v6.GetComponent<Outline>().enabled = false;
		v7.GetComponent<Outline>().enabled = false;
		v8.GetComponent<Outline>().enabled = false;
		v9.GetComponent<Outline>().enabled = false;
		v10.GetComponent<Outline>().enabled = false;
		#endregion

		#region For SetEquipItemOutline
		if (PlayerPrefs.GetInt ("v1e") == 1)
			v1.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v2e") == 1)
			v2.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v3e") == 1)
			v3.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v4e") == 1)
			v4.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v5e") == 1)
			v5.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v6e") == 1)
			v6.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v7e") == 1)
			v7.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v8e") == 1)
			v8.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v9e") == 1)
			v9.GetComponent<Outline>().enabled = true;
		if (PlayerPrefs.GetInt ("v10e") == 1)
			v10.GetComponent<Outline>().enabled = true;
		#endregion
	}
}
