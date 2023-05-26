using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_Game_EasySceneControl : MonoBehaviour {
	private AsyncOperation async;
	public GameObject UI_Game_PokeBallFade;
	// Use this for initialization
	void Start () {
		StartCoroutine(LoadALevel());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			UI_Game_PokeBallFade.GetComponent<Animation> ().Play ("UI_Game_PokeBallFadeOut");
		}
	}

	void FadeOutCallChangeScene(){
		async.allowSceneActivation = true;
	}

	private IEnumerator LoadALevel() {
		async = SceneManager.LoadSceneAsync (6);
		async.allowSceneActivation = false;
		yield return new WaitForSeconds(1f);
	}
}
