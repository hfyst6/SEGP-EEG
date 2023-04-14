using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
	public float moveSpeed = 4;
	public float defaultMoveSpeed = 4;
	public float leftRightSpeed = 4;
	public bool isJumping = false;
	public bool comingDown = false;
	static public bool canMove = false;
	public bool isMoving = false;
	public GameObject playerObject;

	public Text status;

	public float inputValue = 0.0f;
	public float timeElapsed = 0.0f;
	public float timeToChangeInput = 2.0f;
	public float slowThreshold = 0.2f;
	public float stopThreshold = 0.05f;

	public int count = 0;

	void Start(){
		playerObject.GetComponent<Animator> ().Play ("Idle");
	}

	void Update () {
		
		if (canMove == true) {
			// Update time elapsed
			timeElapsed += Time.deltaTime;
			
			
			leftRightSpeed = (int) (count / 10) + defaultMoveSpeed;

			// Generate a new input value every 2 seconds
			if (timeElapsed >= timeToChangeInput)
			{
				inputValue = Random.Range(0.0f, 1.0f);
				timeElapsed = 0.0f;
				count ++ ;

				if (inputValue < stopThreshold) {
					status.GetComponent<Text>().text = "Stop";
					if (!isJumping) {
						playerObject.GetComponent<Animator> ().Play ("Idle");
					}
					isMoving = false;

				} else {
					if (inputValue < slowThreshold){
						status.GetComponent<Text>().text = "Slow";
						if (!isJumping) {
							playerObject.GetComponent<Animator> ().Play ("Standard Run");
						}
						isMoving = true;
						moveSpeed = ((int) (count / 5) + defaultMoveSpeed) / 2;
					} else {
						status.GetComponent<Text>().text = "Normal";
						if (!isJumping) {
							playerObject.GetComponent<Animator> ().Play ("Standard Run");
						}
						isMoving = true;
						moveSpeed = (int) (count / 5) + defaultMoveSpeed;
					}
					
				}
			}
				
			if (isMoving) {
				transform.Translate (Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
			}

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

		if (isMoving) {
			playerObject.GetComponent<Animator> ().Play ("Standard Run");
		} else {
			playerObject.GetComponent<Animator> ().Play ("Idle");
		}
	}
}