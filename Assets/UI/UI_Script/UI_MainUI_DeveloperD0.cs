using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_MainUI_DeveloperD0 : MonoBehaviour {
	public GameObject d0;
	public Sprite d0_1;
	public Sprite d0_2;
	public Sprite d0_3;
	public Sprite d0_4;
	public Sprite d0_5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void d0OnClick(){
		if(d0.GetComponent<Image>().sprite == d0_1)
			d0.GetComponent<Animation> ().Play ("UI_MainUIDeveloperListD0_1");
		else if(d0.GetComponent<Image>().sprite == d0_5)
			d0.GetComponent<Animation> ().Play ("UI_MainUIDeveloperListD0_2");
	}

	public void d0_1animation(){
		d0.GetComponent<Image> ().sprite = d0_1;
	}
	public void d0_2animation(){
		d0.GetComponent<Image> ().sprite = d0_2;
	}
	public void d0_3animation(){
		d0.GetComponent<Image> ().sprite = d0_3;
	}
	public void d0_4animation(){
		d0.GetComponent<Image> ().sprite = d0_4;
	}
	public void d0_5animation(){
		d0.GetComponent<Image> ().sprite = d0_5;
	}
}
