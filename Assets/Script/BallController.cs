using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		//Destroy (this.gameObject, DestroySec);
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !GameManager.gamestart) {
			GameManager.gamestart = true;
			rb.useGravity = true;
		}
	}
}
