using UnityEngine;
using System.Collections;

public class AI_Move : MonoBehaviour {

	public Transform target;
	public float speed = 5;
	private CharacterController cc;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	public Animator anim;
	public static bool AIMove = false;
	public float moveDelay;
	private bool runonce = false;
	// Use this for initialization
	void Start () {
		cc = this.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//print (AIMove);
		Vector3 targetPos = target.position + new Vector3 (0, 0, -0.5f);
		targetPos.y = transform.position.y;
		float distance = Vector3.Distance (targetPos, transform.position);
		if (distance < 0.1) {
			this.transform.localEulerAngles = new Vector3 (0, 180, 0);
			anim.SetBool ("Walk", false);
		} else {
			if (target.position.x < 5 && target.position.x > -5 && AIMove) {
				transform.LookAt (targetPos);
				cc.SimpleMove (transform.forward * speed);
				anim.SetBool ("Walk", true);
			} else {
				anim.SetBool ("Walk", false);
			}
		}
		if (GameManager.gotit && !AIMove && !runonce) {
			runonce = true;
			StartCoroutine (delay (moveDelay));
		}
		moveDirection.y -= gravity * Time.deltaTime;
		cc.Move(moveDirection * Time.deltaTime);
	}
	private IEnumerator delay(float time){
		yield return new WaitForSeconds(time);
		AIMove = true;
		runonce = false;
	}
}