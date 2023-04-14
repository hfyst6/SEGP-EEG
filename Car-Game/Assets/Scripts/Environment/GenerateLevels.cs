using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateLevels : MonoBehaviour
{
	public GameObject[] Section;
	public int zPos = 40;
	public bool creaingSection = false;
	public int secNum;

	void Update () 
	{
		if(!creaingSection)
		{
			creaingSection = !creaingSection;
			StartCoroutine(GenerateSection()); // this Generates a section with a delay
		}
	}

	// suspend execution for waitTime seconds
	IEnumerator GenerateSection()
	{
		secNum = Random.Range (0, 3);
		Instantiate(Section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
		zPos += 40;
		yield return new WaitForSeconds(2);
		creaingSection = false;
	}
}