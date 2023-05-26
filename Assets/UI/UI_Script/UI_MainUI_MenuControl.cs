using UnityEngine;
using System.Collections;

public class UI_MainUI_MenuControl : MonoBehaviour {

	public GameObject UI_MainUI_List;
	public GameObject UI_MainUI_PlayList;
	public GameObject UI_MainUI_GoMainList;
	public GameObject UI_MainUI_DeveloperList;
	public GameObject UI_MainUI_Option;
	public GameObject LoadingPanel;
	public AudioSource AudioSource_Music;
	public AudioSource AudioSource_Sound;


	void Start () {
		if (PlayerPrefs.HasKey ("MusicVolume") == false)
			PlayerPrefs.SetFloat ("MusicVolume", 100);
		if (PlayerPrefs.HasKey ("EffectSoundVolume") == false)
			PlayerPrefs.SetFloat ("EffectSoundVolume", 100);

		UI_MainUI_List.SetActive (false);
		UI_MainUI_GoMainList.SetActive (false);
		AudioSource_Music.GetComponent<AudioSource> ().volume = (PlayerPrefs.GetFloat("MusicVolume")/100);
		AudioSource_Sound.GetComponent<AudioSource> ().volume = (PlayerPrefs.GetFloat("EffectSoundVolume")/100);
		System.GC.Collect ();
	}

	void Update () {
	
	}

	public void PlayButtonOnClick(){
		UI_MainUI_List.GetComponent<Animation> ().Play ("UI_MainUI_ListPanelFadeOut");
	}

	public void GoMainListButtonOnClick(){
		UI_MainUI_GoMainList.GetComponent<Animation> ().Play ("UI_MainUI_GoMainListFadeOut");

		//PlayList
		if (UI_MainUI_PlayList.activeSelf == true) {
			UI_MainUI_PlayList.GetComponent<Animation> ().Play ("UI_MainUI_PlayListFadeOut");
			UI_MainUI_List.SetActive (true);
			UI_MainUI_List.GetComponent<Animation> ().Play ("UI_MainUI_ListPanelMove");
		}

		//DeveloperList
		if (UI_MainUI_DeveloperList.activeSelf == true) {
			UI_MainUI_DeveloperList.GetComponent<Animation> ().Play ("UI_MainUI_DeveloperListFadeOut");
		}

		//Option
		if (UI_MainUI_Option.activeSelf == true) {
			UI_MainUI_Option.GetComponent<Animation> ().Play ("UI_MainUI_OptionFadeOut");
		}


		LoadingPanel.SetActive (false);
	}

	public void GoStoreButtonOnClick(){
		LoadingPanel.SetActive(true);
		LoadingPanel.GetComponent<Animation> ().Play ("UI_MainUI_LoadingpanelFadeIn");
		UI_MainUI_LoadingPanelControl.LoadSceneNumber = 2;
	}

	public void GoOptionButtonOnClick(){
		UI_MainUI_Option.SetActive (true);
		UI_MainUI_Option.GetComponent<Animation> ().Play ("UI_MainUI_OptionFadeIn");
		UI_MainUI_GoMainList.SetActive (true);
		UI_MainUI_GoMainList.GetComponent<Animation> ().Play ("UI_MainUI_GoMainListFadeIn");
	}

	public void GoDeveloperListButtonOnClick(){
		UI_MainUI_DeveloperList.SetActive(true);
		UI_MainUI_DeveloperList.GetComponent<Animation> ().Play ("UI_MainUI_DeveloperListFadeIn");
		UI_MainUI_GoMainList.SetActive (true);
		UI_MainUI_GoMainList.GetComponent<Animation> ().Play ("UI_MainUI_GoMainListFadeIn");
	}

	public void GoExitButtonOnClick(){
		Application.Quit ();
	}
}
