using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmotin : MonoBehaviour {
	Transform tr; 
	public Transform target;
	float speed=5f;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		tr.position= Vector3.MoveTowards(tr.position,target.position,Time.deltaTime);

	}
	void OnCollisionEnter(Collision coll)
	{
		coll.gameObject.transform.parent = tr;
	}
	void OnCollisionExit(Collision coll)
	{
		coll.gameObject.transform.parent = null;
	}
}
