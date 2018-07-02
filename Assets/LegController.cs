using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegController : MonoBehaviour {
	public char setKey;
	Rigidbody2D rigid2D;

	float upForce = 20.0f;
	float upForceOther = 15.0f;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((this.setKey.Equals('r') && Input.GetKey(KeyCode.RightArrow)) || (this.setKey.Equals('l') && Input.GetKey(KeyCode.LeftArrow))) {
			this.rigid2D.AddForce(transform.up * this.upForce);
		}
        if ((this.setKey.Equals('l') && Input.GetKey(KeyCode.RightArrow)) || (this.setKey.Equals('r') && Input.GetKey(KeyCode.LeftArrow)))
        {
            this.rigid2D.AddForce(transform.up * this.upForceOther);
        }
	}
}
