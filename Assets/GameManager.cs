using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	GameObject Timer;

	// Use this for initialization
	void Start () {
		this.Timer = GameObject.Find("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Clear () {
		this.Timer.GetComponent<TimerController>().Stop();
	}
}
