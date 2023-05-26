using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour {

	private Text scoreViewer;
	// Use this for initialization
	void Start () {
		scoreViewer = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreViewer.text = GameManager.PlayerScore + "-" + GameManager.EnemyScore;
	}
}
