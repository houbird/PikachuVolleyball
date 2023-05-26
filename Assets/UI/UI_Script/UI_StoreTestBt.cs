using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_StoreTestBt : MonoBehaviour {
	public GameObject UI_StoreUICoin;

	#region GameObject P and V;
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
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Add(){
		int i = PlayerPrefs.GetInt ("Coin")+100;
		PlayerPrefs.SetInt("Coin", i);
		UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
	}

	public void Clear(){
		PlayerPrefs.SetInt("Coin", 0);
		UI_StoreUICoin.GetComponent<Text> ().text ="" + PlayerPrefs.GetInt ("Coin");
		for (int i = 1; i <= 10; i++) {
			PlayerPrefs.SetInt ("p" + i , 0);
			PlayerPrefs.SetInt ("v" + i, 0);
			PlayerPrefs.SetInt ("p" + i + "e", 0);
			PlayerPrefs.SetInt ("v" + i + "e", 0);
		}
		PlayerPrefs.SetInt ("p1", 1);
		PlayerPrefs.SetInt ("v1", 1);
		PlayerPrefs.SetInt ("p1e", 1);
		PlayerPrefs.SetInt ("v1e", 1);

		#region For SetActive
		p1s.SetActive(true);
		p2s.SetActive(false);
		p3s.SetActive(false);
		p4s.SetActive(false);
		p5s.SetActive(false);
		p6s.SetActive(false);
		p7s.SetActive(false);
		p8s.SetActive(false);
		p9s.SetActive(false);
		p10s.SetActive(false);

		v1s.SetActive(true);
		v2s.SetActive(false);
		v3s.SetActive(false);
		v4s.SetActive(false);
		v5s.SetActive(false);
		v6s.SetActive(false);
		v7s.SetActive(false);
		v8s.SetActive(false);
		v9s.SetActive(false);
		v10s.SetActive(false);

		p1.GetComponent<Outline>().enabled = true;
		p2.GetComponent<Outline>().enabled = false;
		p3.GetComponent<Outline>().enabled = false;
		p4.GetComponent<Outline>().enabled = false;
		p5.GetComponent<Outline>().enabled = false;
		p6.GetComponent<Outline>().enabled = false;
		p7.GetComponent<Outline>().enabled = false;
		p8.GetComponent<Outline>().enabled = false;
		p9.GetComponent<Outline>().enabled = false;
		p10.GetComponent<Outline>().enabled = false;

		v1.GetComponent<Outline>().enabled = true;
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
	}
	public void Delallprefs()
	{
		PlayerPrefs.DeleteAll();
	}
}
