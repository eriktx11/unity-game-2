using UnityEngine;
using System.Collections;

public class adr_balance : MonoBehaviour {

	GameObject player;
	Rigidbody rigidbody;
	float popForce=100f;

	void Start(){
		rigidbody = GetComponent<Rigidbody> ();
	}


	void Update () {
		//the more it taps the more it jumps
		if(Input.GetMouseButtonDown(0)) 
			rigidbody.AddForce(Vector3.up*popForce,ForceMode.Force);

	}
		
}