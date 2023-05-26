using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Message : MonoBehaviour {

	public static Text text;
	private bool RunOnce = false;
	public bool easy;
	public bool normal;
	public bool hard;

	// Use this for initialization
	void Start () {
		text = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && GameManager.gamestart) {
			text.text = " ";
		}
		if (!GameManager.gamestart && !RunOnce && text.text == " ") {
			RunOnce = true;
			//球掉落至我方場地↓
			if ((Fall.FallPos.z < 0 && Fall.FallPos.z > -10) && (Fall.FallPos.x < 5 && Fall.FallPos.x > -5)) {
				text.text = "Enemy's scoring";
				GameManager.EnemyScore++;
				GameManager.ballRestartPosition = new Vector3 (0, 5, 7);
			} 
			//球掉落至對方場地↓
			else if ((Fall.FallPos.z > 0 && Fall.FallPos.z < 10) && (Fall.FallPos.x < 5 && Fall.FallPos.x > -5)) {
				text.text = "Player's scoring";
				GameManager.PlayerScore++;
				GameManager.ballRestartPosition = new Vector3 (0, 5, -7);
			}
			//我方出界
			else if (Fall.FallPos.z > 0) {
				text.text = "Enemy's scoring";
				GameManager.EnemyScore++;
				GameManager.ballRestartPosition = new Vector3 (0, 5, 7);
			} 
			//AI出界
			else if (Fall.FallPos.z < 0) {
				text.text = "Player's scoring";
				GameManager.PlayerScore++;
				GameManager.ballRestartPosition = new Vector3 (0, 5, -7);
			}
			StartCoroutine (delay (1f));
		}
		if (!GameManager.gamestart) {
			if (GameManager.EnemyScore == 15) {
				//Application.LoadLevel("loseScene");
				SceneManager.LoadSceneAsync (10);
				GameManager.EnemyScore = 0;
				GameManager.PlayerScore = 0;
				GameManager.RestartValue ();
			}
			else if(GameManager.PlayerScore == 15){
				//Application.LoadLevel("winScene");
				SceneManager.LoadSceneAsync (9);
				GameManager.EnemyScore = 0;
				GameManager.PlayerScore = 0;
				GameManager.RestartValue ();
				if (easy) {
					int i = PlayerPrefs.GetInt ("Coin") + 25;
					PlayerPrefs.SetInt ("Coin", i);
				} else if (normal) {
					int i = PlayerPrefs.GetInt ("Coin") + 50;
					PlayerPrefs.SetInt ("Coin", i);
				} else if (hard) {
					int i = PlayerPrefs.GetInt ("Coin")+100;
					PlayerPrefs.SetInt("Coin", i);
				}
			}
		}
	}

	private IEnumerator delay(float time)
	{
		yield return new WaitForSeconds(time);
		RunOnce = false;
		text.text = "TOUCH TO RESET";
		GameManager.IsReset = true;
	}
}
