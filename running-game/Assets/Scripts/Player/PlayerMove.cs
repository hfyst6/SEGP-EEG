using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float moveSpeed = 10;
	public float leftRightSpeed = 4;
	public bool isJumping = false;
	public bool comingDown = false;
	static public bool canMove = false;
	public GameObject playerObject;


	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
		if (canMove == true) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
				// check first if the player is within the game boundary, if so he can move left
				if (this.gameObject.transform.position.x > LevelBoundary.leftSide) {
					transform.Translate (Vector3.left * Time.deltaTime * leftRightSpeed);
				}
			}
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
				if (this.gameObject.transform.position.x < LevelBoundary.rightSide) {
					transform.Translate (Vector3.left * Time.deltaTime * leftRightSpeed * -1);
				}
			}
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)  || Input.GetKey (KeyCode.Space)) {
				if (!isJumping) {
					isJumping = true;
					playerObject.GetComponent<Animator> ().Play ("Jump");
					StartCoroutine (JumpSequence ());
				}
			}
		}
		if (isJumping == true) {
			if (comingDown == false) {
				transform.Translate (Vector3.up * Time.deltaTime * 5, Space.World);
			}
			if (comingDown == true) {
				transform.Translate (Vector3.up * Time.deltaTime * -5, Space.World);
			}

		}
	}

	IEnumerator JumpSequence(){
		yield return new WaitForSeconds (0.45f);
		comingDown = true;
		yield return new WaitForSeconds (0.45f);
		isJumping = false;
		comingDown = false;
		transform.position = new Vector3 (transform.position.x, 1.5f, transform.position.z);
		playerObject.GetComponent<Animator> ().Play ("Standard Run");
	}
}