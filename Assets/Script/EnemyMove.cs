using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public static Transform target;
	private CharacterController cc;
	public static bool startMove = false;
	public float speed = 5;
	// Use this for initialization
	void Start () {
		cc = this.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			target = GameObject.FindGameObjectWithTag ("Ball").transform;
		} else {
			/*if (target != null) {
				Vector3 targetPos = target.position;
				targetPos.y = transform.position.y;
				transform.LookAt (targetPos);
			}*/
			if (startMove) {
				if (target.position.z > 5) {
					Vector3 targetPos = target.position;
					targetPos.y = transform.position.y;
					transform.LookAt (targetPos);
					cc.SimpleMove (transform.forward * speed);
				} else {
					if (target.position.x > this.transform.position.x) {
						transform.LookAt (Vector3.zero);
						cc.SimpleMove (-transform.right * speed);
					} else if (target.position.x < this.transform.position.x) {
						transform.LookAt (Vector3.zero);
						cc.SimpleMove (transform.right * speed);
					}
				}
			} else {
				Quaternion q = new Quaternion();
				q.eulerAngles = new Vector3 (0, 0, 0);
				transform.rotation = q;
			}
		}
	}
}
