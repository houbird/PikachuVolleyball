using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Transform target;
	public float speed = 5f;
	public float jump_speed = 8f;
	private CharacterController cc;
	private bool isjump = true;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	public Animator anim;
	private bool inAir = false;
	// Use this for initialization
	void Start () {
		cc = this.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPos = target.position;
		targetPos.y = transform.position.y;
		/*float distance = Vector3.Distance (targetPos, transform.position);
		if (distance < 0.5 && !GameManager.gotit) {
			if (distance < 0.3) {
				speed = 0.3f;
			} else {
				speed = 3f;
			}
		} else {
			speed = 5f;
		}*/
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		if (JoyStick.h != 0 || JoyStick.v != 0) {
			h = JoyStick.h;
			v = JoyStick.v;
		}

		if (Mathf.Abs (h) > 0.1 || Mathf.Abs (v) > 0.1) {
			Vector3 targetDir = new Vector3 (h, 0, v);
			transform.LookAt (targetDir + transform.position);
			cc.SimpleMove (transform.forward * speed);
			anim.SetBool ("Walk", true);
		} else {
			anim.SetBool ("Walk", false);
		}

		if (!cc.isGrounded) {
			inAir = true;
		}
		if (inAir) {
			if (cc.isGrounded) {
				inAir = false;
				isjump = true;
				anim.SetBool ("Jump", false);
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		cc.Move(moveDirection * Time.deltaTime);
	}

	public void Jump(){
		if (isjump) {
			anim.SetBool ("Jump", true);
			moveDirection.y = jump_speed;
			isjump = false;
		}
	}
}
