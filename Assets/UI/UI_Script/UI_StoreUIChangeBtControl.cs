using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_StoreUIChangeBtControl : MonoBehaviour {
	public GameObject UI_StoreUI_ChangeShopBt;
	public GameObject UI_StoreShop1;
	public GameObject UI_StoreShop2;
	public Sprite UI_Store_BtImg1;
	public Sprite UI_Store_BtImg2;

	public GameObject UI_StoreUI_3DModelSkin;
	public GameObject UI_StoreUI_3DModelVolleyBall;

	public Slider LoadingBar;
	public GameObject LoadingPanel;
	public GameObject LoadingPercent;
	private AsyncOperation async;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UI_StoreUI_ChangeShopBtOnClick(){
		if (UI_StoreShop1.activeSelf == true) {
			UI_StoreShop1.SetActive (false);
			UI_StoreShop2.SetActive (true);
			UI_StoreUI_ChangeShopBt.GetComponent<Image> ().sprite = UI_Store_BtImg1;
			UI_StoreUI_3DModelSkin.SetActive (false);
			UI_StoreUI_3DModelVolleyBall.SetActive (true);
		} else {
			UI_StoreShop2.SetActive (false);
			UI_StoreShop1.SetActive (true);
			UI_StoreUI_ChangeShopBt.GetComponent<Image> ().sprite = UI_Store_BtImg2;
			UI_StoreUI_3DModelSkin.SetActive (true);
			UI_StoreUI_3DModelVolleyBall.SetActive (false);
		}
		System.GC.Collect ();
	}

	public void UI_StoreUI_ReturnMainUIbtOnClick(){
		System.GC.Collect ();
		LoadScene ();
	}

	void LoadScene(){
		//SceneManager.LoadScene (1);
		LoadingPanel.SetActive(true);
		StartCoroutine(LoadALevel());
	}

	private IEnumerator LoadALevel() {
		async = SceneManager.LoadSceneAsync (1);
		while (!async.isDone) {
			LoadingBar.value = async.progress*100;
			LoadingPercent.GetComponent<Text> ().text = "" + (int)LoadingBar.value;
			yield return null;
		}
	}
}
