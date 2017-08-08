using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour {

	private Rigidbody _rb;

	[SerializeField]
	[Range(2,10)]
	private float _moveSpeed = 5;


	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		var h = Input.GetAxis("Horizontal");
		if(h != 0){
				_rb.AddForce(new Vector3(_moveSpeed * h, 0, 0), ForceMode.Acceleration);
		}
		var v = Input.GetAxis("Vertical");
		if(v != 0){
				_rb.AddForce(new Vector3(0, _moveSpeed * v, 0), ForceMode.Impulse);
		}
	}
}
