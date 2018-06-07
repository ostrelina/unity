using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoblock : MonoBehaviour {
	Transform tr;
  
    // Use this for initialization
    void Start () {
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		Debug.Log ("ok");
		tr.position= new Vector3 (tr.position.x,9f,tr.position.z);

	}
    void OnCollisionEnter(Collision coll)
    {
        coll.gameObject.transform.parent = tr;
    }
   
}


