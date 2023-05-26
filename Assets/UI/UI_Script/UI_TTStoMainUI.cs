using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_TTStoMainUI : MonoBehaviour {

	public GameObject TTS_Panel;
	public GameObject TouchToStartText;
	public Slider LoadingBar;
	public GameObject LoadingPanel;
	public GameObject LoadingPercent;
	private AsyncOperation async;

	void Start(){
		for (int i = 2; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("p" + i) == false)
				PlayerPrefs.SetInt ("p" + i, 0);
		}
		for (int i = 2; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("v" + i) == false)
				PlayerPrefs.SetInt ("v" + i, 0);
		}
		for (int i = 2; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("p" + i + "e") == false)
				PlayerPrefs.SetInt ("p" + i + "e", 0);
		}
		for (int i = 2; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("v" + i + "e") == false)
				PlayerPrefs.SetInt ("v" + i + "e", 0);
		}
		if (PlayerPrefs.HasKey ("p1") == false)
			PlayerPrefs.SetInt ("p1", 1);
		if (PlayerPrefs.HasKey ("v1") == false)
			PlayerPrefs.SetInt ("v1", 1);
		if (PlayerPrefs.HasKey ("p1e") == false)
			PlayerPrefs.SetInt ("p1e", 1);
		if (PlayerPrefs.HasKey ("v1e") == false)
			PlayerPrefs.SetInt ("v1e", 1);
		
		if (PlayerPrefs.HasKey ("Coin")==false) {
			PlayerPrefs.SetInt ("Coin", 0);
		}
	}

	void Update () {
		if (Input.GetMouseButton(0)) {
			TouchToStartText.SetActive (false);
			TTS_Panel.GetComponent<Animation> ().Play ("UI_TTSFadeOut");
		}
	}

	void LoadScene(){
		//SceneManager.LoadScene (1);
		LoadingPanel.SetActive(true);
		StartCoroutine(LoadALevel());
	}

	private IEnumerator LoadALevel() {
		async = SceneManager.LoadSceneAsync (1);
		while (!async.isDone) {
			LoadingBar.value = async.progress;
			LoadingPercent.GetComponent<Text> ().text = "" + (int)LoadingBar.value;
			yield return null;
		}
	}
}
