using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {
	float countTime = 0.0f;
	bool isStop = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isStop) return;
    countTime += Time.deltaTime;
    GetComponent<Text>().text = countTime.ToString("F2");
  }

	public void Stop () {
		this.isStop = true;
	}
}
