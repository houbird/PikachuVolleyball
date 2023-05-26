using UnityEngine;
using System.Collections;

public class UI_MainUI_ListPanel : MonoBehaviour {
	public GameObject UI_MainUI_List;
	public GameObject UI_MainUI_PlayList;
	public GameObject UI_MainUI_GoMainList;

	void Start(){
	}

	void UI_MainUI_ListPanelFadeOut(){
		UI_MainUI_List.SetActive (false);
	}

	void UI_MainUI_PlayListShow (){
		UI_MainUI_PlayList.SetActive (true);
		UI_MainUI_PlayList.GetComponent<Animation> ().Play ("UI_MainUI_PlayListFadeIn");
		UI_MainUI_GoMainList.SetActive (true);
		UI_MainUI_GoMainList.GetComponent<Animation> ().Play ("UI_MainUI_GoMainListFadeIn");
	}
}
