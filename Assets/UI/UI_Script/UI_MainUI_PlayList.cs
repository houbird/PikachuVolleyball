using UnityEngine;
using System.Collections;

public class UI_MainUI_PlayList : MonoBehaviour {
	public GameObject UI_MainUI_Playlist;
	public GameObject LoadingPanel;

	void Start () {
	
	}

	void Update () {
	
	}

	public void ListFadeOut(){
		UI_MainUI_Playlist.SetActive (false);
	}

	public void EasyBtOnclick(){
		LoadingPanel.SetActive(true);
		LoadingPanel.GetComponent<Animation> ().Play ("UI_MainUI_LoadingpanelFadeIn");
		UI_MainUI_LoadingPanelControl.LoadSceneNumber = 3;
	}

	public void NormalBtOnclick(){
		LoadingPanel.SetActive(true);
		LoadingPanel.GetComponent<Animation> ().Play ("UI_MainUI_LoadingpanelFadeIn");
		UI_MainUI_LoadingPanelControl.LoadSceneNumber = 4;
	}

	public void HardBtOnclick(){
		LoadingPanel.SetActive(true);
		LoadingPanel.GetComponent<Animation> ().Play ("UI_MainUI_LoadingpanelFadeIn");
		UI_MainUI_LoadingPanelControl.LoadSceneNumber = 5;
	}
}
