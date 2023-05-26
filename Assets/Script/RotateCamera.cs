using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	public GameObject cube;
	public float speed;
	public GameObject c;
	private bool stop = false;
	public Animator anim;
	public bool WinScene;
	// Use this for initialization
	void Start () {
		if (WinScene) {
			anim.SetTrigger ("Victory");
		} else {
			anim.SetTrigger ("Lose");
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (transform.eulerAngles.y <= 180) {
			transform.RotateAround (cube.transform.position, new Vector3 (0, 10, 0), 100 * speed * Time.deltaTime);
		} else if(!stop){
			stop = true;
			StartCoroutine (cool ());
		}
	}
	IEnumerator cool()
	{
		for (int i = 0; i < 20; i++) {
			c.transform.localPosition += new Vector3 (0, 0, 0.2f);
			yield return 0;
		}

	}
}
