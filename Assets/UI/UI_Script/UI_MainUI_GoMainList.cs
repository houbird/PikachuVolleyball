using UnityEngine;
using System.Collections;

public class UI_MainUI_GoMainList : MonoBehaviour {
	public GameObject UI_MainUI_GoMainlist;

	void Start () {
	
	}


	void Update () {
	
	}

	void UI_MainUI_GoMainListFadeOut(){
		UI_MainUI_GoMainlist.SetActive (false);
		System.GC.Collect ();
	}
}
