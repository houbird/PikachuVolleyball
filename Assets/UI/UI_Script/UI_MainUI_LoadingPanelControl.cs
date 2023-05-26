using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_MainUI_LoadingPanelControl : MonoBehaviour {

	public Slider LoadingBar;
	public GameObject LoadingPanel;
	public GameObject LoadingPercent;
	private AsyncOperation async;
	public static int LoadSceneNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadingPanelFadeInCall(){
		StartCoroutine(LoadALevel(LoadSceneNumber));
	}

	private IEnumerator LoadALevel(int LoadSceneNumber) {
		async = SceneManager.LoadSceneAsync (LoadSceneNumber);
		while (!async.isDone) {
			LoadingBar.value = async.progress*100;
			LoadingPercent.GetComponent<Text> ().text = "" + (int)LoadingBar.value;
			yield return null;
		}
	}

	public void WinLoseToMenuBtClick(){
		StartCoroutine(LoadALevel(1));
	}
}
