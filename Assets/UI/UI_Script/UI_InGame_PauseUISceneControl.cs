using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_InGame_PauseUISceneControl : MonoBehaviour {

	public Slider LoadingBar;
	public GameObject LoadingPanel;
	public GameObject LoadingPercent;
	private AsyncOperation async;
	public static int LoadSceneNumber;
	public static bool PauseCheckBool = false; //0 is inGame, 1 is OnPause.
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void QuitYesBtClick(){
		GameManager.EnemyScore = 0;
		GameManager.PlayerScore = 0;
		GameManager.RestartValue ();
		StartCoroutine(LoadALevel(1));
	}

	private IEnumerator LoadALevel(int LoadSceneNumber) {
		GameManager.EnemyScore = 0;
		GameManager.PlayerScore = 0;
		GameManager.RestartValue ();
		async = SceneManager.LoadSceneAsync (1);
		while (!async.isDone) {
			LoadingBar.value = async.progress*100;
			LoadingPercent.GetComponent<Text> ().text = "" + (int)LoadingBar.value;
			yield return null;
		}
	}

	public void PlayStop (){
		if(PauseCheckBool == false){
			//pause
			Time.timeScale = 0;
			PauseCheckBool = true;
			//StartCoroutine( PauseBt.Play("animName", false, () => Debug.Log("onComplete")) );
		}else{
			//playgame
			Time.timeScale = 1;
			PauseCheckBool = false;
		}
	}
}
