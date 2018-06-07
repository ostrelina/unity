using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mygame : MonoBehaviour {
	float v;
	float h;
	Rigidbody rb;
	Transform tr;
	bool k=false;
	public Transform platform;
    int score=0;
    public Text scoreText;

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		Physics.gravity = new Vector3 (0, -20f, 0);

	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (0, h, 0);
		rb.AddForce (tr.forward*v* 100f);


		tr.Rotate (move * 5f);
		if(Input.GetKeyDown (KeyCode.Space) && k== true) {
			Vector3 position = new Vector3 (0, 450, 0);
			rb.AddForce (position);
			k = false;
		}
	}
	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag == "pui") {
			k = true;

		}
		if (arg.gameObject.tag == "puki") {
			Vector3 position = new Vector3(0,Random.Range(100,300),0);
			rb.AddForce (position);
		}
		if (arg.gameObject.tag == "wui") {
			Application.LoadLevel("sen2");
		}
		if (arg.gameObject.tag == "rip") {
			Application.LoadLevel("sen3");
		}
}

    void OnTriggerEnter( Collider arg) {
        Debug.Log("OnTriggerEnter() was called");
        if (arg.gameObject.tag == "Coin")
        {
            Debug.Log("Other object is coin");
            score =score+ 5;
            scoreText.text = "score: "+score.ToString();
            Debug.Log("Score is now" + score);
            Destroy(arg.gameObject);
        }
    }
}
