using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static bool gamestart = false;
	//public static bool ball_landing = false;
	public static int PlayerScore = 0;
	public static int EnemyScore = 0;
	public static bool IsReset = false;
	public static bool gotit = false; //player接到球惹
	public GameObject Player;
	public GameObject Enemy;
	public GameObject PlayerTarget;
	public GameObject EnemyTarget;
	public static Vector3 ballRestartPosition;

	// Use this for initialization
	void Start () {
		Input.multiTouchEnabled = true;
		ballRestartPosition = new Vector3 (0, 5, -7);
	}
	
	// Update is called once per frame
	void Update () {
		if (IsReset && Input.GetMouseButtonDown(0)) {
			AI_Move.AIMove = false;
			gamestart = true;
			IsReset = false;
			Player.transform.position = new Vector3 (0, 0.6f, -7);
			Player.transform.localEulerAngles = Vector3.zero;

			Enemy.transform.position = new Vector3 (0, 0.5f, 7);
			Enemy.transform.localEulerAngles = new Vector3 (0, 180, 0);

			PlayerTarget.transform.position = new Vector3 (0, 0, 7);
			EnemyTarget.transform.position = new Vector3 (0, 0, -7);
			BallSkinController.Ball.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			BallSkinController.Ball.transform.position = ballRestartPosition;
		}
		if (gotit) {
			PlayerTarget.SetActive (true);
			EnemyTarget.SetActive (false);
		} else {
			PlayerTarget.SetActive (false);
			EnemyTarget.SetActive (true);
		}
	}

	public void getPoint(){
		PlayerScore = 14;
	}
	public void lostPoint(){
		EnemyScore = 14;
	}

	public static void RestartValue(){
		AI_Move.AIMove = false;
		gamestart = false;
		IsReset = false;
		gotit = false;
	}
}
