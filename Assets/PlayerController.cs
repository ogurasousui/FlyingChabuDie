using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	Rigidbody2D rigid2D;
	AudioSource aud;

  GameObject GameManager;

	public AudioClip hitSE;
	public AudioClip clearSE;
	public AudioClip resetSE;

	Vector3 initialPosition;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D>();
		this.aud = GetComponent<AudioSource>();
		this.GameManager = GameObject.Find("GameManager");
		this.initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKey(KeyCode.Space)) {
			this.ResetPosition();
		}
	}

  void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "goal") {
			this.GameManager.GetComponent<GameManager>().Clear();
      this.aud.PlayOneShot(this.clearSE, 0.3f);
		} else if (col.gameObject.tag == "reset") {
			this.ResetPosition();
      this.aud.PlayOneShot(this.resetSE, 0.3f);
		} else	{
			this.aud.PlayOneShot(this.hitSE, 0.3f);
		}
	}

	void ResetPosition () {
		this.rigid2D.velocity = Vector2.zero;
		transform.SetPositionAndRotation(this.initialPosition, Quaternion.Euler(0, 0, 0));
	}
}
