﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevels : MonoBehaviour {
	public string parentName;
	
	// Update is called once per frame
	void Start () {
		parentName = transform.name;
		StartCoroutine (DestroyClone ());
	}

	IEnumerator DestroyClone(){
		yield return new WaitForSeconds (30);
		if (parentName == "Section(Clone)")
		{
			Destroy (gameObject);
		}
			
	}
}
