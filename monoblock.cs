using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoblock : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed=Random.Range(0.4f,2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed * Time.deltaTime,0 , 0);
	}
}
