using UnityEngine;
using System.Collections;

public class AI_FightBack : MonoBehaviour {

	public AudioSource SoundAudioSource;
	public AudioClip Game_touchBallSound;

	public Transform target;
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider_ball){
		if (collider_ball.tag == "Ball" && GameManager.gamestart) {
			SoundAudioSource.GetComponent<AudioSource> ().PlayOneShot (Game_touchBallSound);
			target.position = new Vector3 (this.transform.position.x+Random.Range(-2,2), 0, Random.Range(-3,-9));
			float ang = PlayerFightBack.ElevationAngle(target,this.transform);
			this.transform.localEulerAngles = new Vector3 (0, 180, 0);
			GameManager.gotit = false;
			AI_Move.AIMove = false;

			float shootAng = ang + 15;
			// shoot 15 degree higher
			// limit the shoot angle to a convenient range:
			shootAng = Mathf.Clamp(shootAng, 55, 60);
			// and shoot:
			BallSkinController.Ball.GetComponent<Rigidbody>().velocity = PlayerFightBack.BallisticVel(target, shootAng, BallSkinController.Ball.transform);
		}
	}
}
