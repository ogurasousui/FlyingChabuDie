using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour {
	Rigidbody2D rigid2D;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        	if (Input.GetKey(KeyCode.Space)) {
			this.rigid2D.velocity = Vector2.zero;
			transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
		}
	}
}
