using UnityEngine;
using System.Collections;

public class UI_MainUI_DeveloperListControl : MonoBehaviour {
	public GameObject UI_MainUI_DeveloperList;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ListFadeOut(){
		UI_MainUI_DeveloperList.SetActive (false);
	}

}
