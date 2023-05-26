using UnityEngine;
using System.Collections;

public class UI_MainUI_PikachuAnimationCallPlay : MonoBehaviour {
	public GameObject UI_MainUI_Title;
	public GameObject UI_MainUI_List;

	void UI_MainUI_TitleShow(){
		UI_MainUI_Title.GetComponent<Animation> ().Play ("UI_MainUI_TitleShow");
	}

	void UI_MainUI_ListPanelMove(){
		UI_MainUI_List.SetActive (true);
		UI_MainUI_List.GetComponent<Animation> ().Play ("UI_MainUI_ListPanelMove");
		System.GC.Collect ();
	}

}
