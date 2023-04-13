using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour {
	public GameObject disDispaly;
	public GameObject disEndDispaly;
	public int disRun;
	public bool addingDis = false;
	public float disDelay = 0.35f;
	
	// Update is called once per frame
	void Update () {
		if (addingDis == false) {
			addingDis = true;
			StartCoroutine (AddingDis ());
		}

	}
	IEnumerator AddingDis()
	{
		disRun += 1;
		disDispaly.GetComponent<Text>().text = "" + disRun;
		disEndDispaly.GetComponent<Text>().text = "" + disRun;
		yield return new WaitForSeconds (disDelay);
		addingDis = false;
	}

}
