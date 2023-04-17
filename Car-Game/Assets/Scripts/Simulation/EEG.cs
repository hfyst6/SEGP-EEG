using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EEG : MonoBehaviour {

	public GameObject character;
	public float speed = 5.0f;
	public float threshold = 0.5f;

	private bool isMoving = false;
	private float inputValue = 0.0f;

	void Update()
	{
		// Simulate EEG input
		inputValue = Mathf.Sin(Time.time);

		// Check if the input value is above the threshold
		if (inputValue > threshold && !isMoving)
		{
			// Start moving the character
			isMoving = true;
			character.GetComponent<Animator>().SetBool("isRunning", true);
		}
		else if (inputValue < threshold && isMoving)
		{
			// Stop moving the character
			isMoving = false;
			character.GetComponent<Animator>().SetBool("isRunning", false);
		}

		// Move the character forward
		if (isMoving)
		{
			character.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
		}
	}
}
