using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mygame : MonoBehaviour {
	float v;
	float h;
	Rigidbody rb;
	Transform tr;
	bool k=false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (0, h, 0);
		rb.AddForce (tr.forward*v* 20f);
		tr.Rotate (move * 5f);
		if(Input.GetKeyDown (KeyCode.Space) && k== true) {
			Vector3 position = new Vector3 (0, 400, 0);
			rb.AddForce (position);
			k = false;
		}
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "pui") {
			k = true;
		}
		if (arg.gameObject.tag == "puki") {
			Vector3 position = new Vector3(0,Random.Range(100,350),0);
			rb.AddForce (position);
		}
}
}
