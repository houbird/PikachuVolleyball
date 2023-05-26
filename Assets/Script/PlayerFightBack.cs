using UnityEngine;
using System.Collections;

public class PlayerFightBack : MonoBehaviour {

	public AudioSource SoundAudioSource;
	public AudioClip Game_touchBallSound;

	public Transform target;
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider_ball){
		if (collider_ball.tag == "Ball" && GameManager.gamestart) {
			SoundAudioSource.GetComponent<AudioSource> ().PlayOneShot (Game_touchBallSound);
			target.position = new Vector3 (this.transform.position.x + JoyStick.h * 3, 0, Random.Range(3,9));
			GameManager.gotit = true;

			float ang = ElevationAngle(target,this.transform);
			float shootAng = ang + 55;
			// shoot 55 degree higher
			// limit the shoot angle to a convenient range:
			shootAng = Mathf.Clamp(shootAng, 55, 60);
			// and shoot:
			BallSkinController.Ball.GetComponent<Rigidbody>().velocity = BallisticVel(target, shootAng, BallSkinController.Ball.transform);
		}
	}

	public static float ElevationAngle(Transform target, Transform MySelf) {
		// find the cannon->target vector:
		Vector3 dir = target.position - MySelf.position;
		// create a horizontal version of it:
		Vector3 dirH =new Vector3(dir.x, 0, dir.y);
		// measure the unsigned angle between them:
		float ang = Vector3.Angle(dir, dirH);
		// add the signal (negative is below the cannon):
		if (dir.y < 0) ang = -ang;
		return ang;
	}

	public static Vector3 BallisticVel(Transform target, float angle, Transform MySelf){
		Vector3 dir = target.position - MySelf.position; 
		// get target direction 
		float h = dir.y; 
		// get height difference 
		dir.y = 0; 
		// retain only the horizontal direction 
		float dist = dir.magnitude ; 
		// get horizontal distance 
		float a = angle * Mathf.Deg2Rad; 
		// convert angle to radians 
		dir.y = dist * Mathf.Tan(a); 
		// set dir to the elevation angle 
		dist += h / Mathf.Tan(a); 
		// correct for small height differences 
		// calculate the velocity magnitude 
		float vel = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a)); 
		return vel * dir.normalized; 
	}
}
