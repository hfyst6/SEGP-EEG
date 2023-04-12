﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollison : MonoBehaviour {
	public GameObject thePlayer;
	public GameObject charModel;
	public AudioSource crashThud;
	public GameObject mainCam;
	public GameObject levelControl;


	void OnTriggerEnter(Collider other)
	{
		this.gameObject.GetComponent<BoxCollider>().enabled = false;
		thePlayer.GetComponent<PlayerMove>().enabled = false;
		charModel.GetComponent<Animator>().Play("Stumble Backwards");
		levelControl.GetComponent<LevelDistance>().enabled = false;
		crashThud.Play ();
		mainCam.GetComponent<Animator>().enabled = true;
		levelControl.GetComponent<EndRun> ().enabled = true;

	}

}
