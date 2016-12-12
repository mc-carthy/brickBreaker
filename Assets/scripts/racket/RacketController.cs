using UnityEngine;

public class RacketController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private void FixedUpdate () {
		float h = Input.GetAxisRaw("Horizontal");

		if (h > 0) {
			MoveRight(true, moveSpeed);
		}
		if (h < 0) {
			MoveRight(false, moveSpeed);
		}
	}

	private void MoveRight(bool isMovingRight, float moveSpeed) {
		Vector3 temp = transform.position;
		temp.x += (isMovingRight) ? moveSpeed * Time.deltaTime : -moveSpeed * Time.deltaTime;
		transform.position = temp;
	}
}
