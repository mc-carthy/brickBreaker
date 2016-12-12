using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;

	private Rigidbody2D rb;

	private void Awake () {
		rb = GetComponent<Rigidbody2D>();
	}

	private void Start () {
		rb.velocity = Vector2.up * moveSpeed;
	}

	private float CalculateBounceDirection (Vector2 ballPosition, Vector2 racketPosition) {
		return (ballPosition.x - racketPosition.x);
	}

	private void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "racket") {
			float x = CalculateBounceDirection(transform.position, other.transform.position);
			Vector2 direction = new Vector2(x, 1).normalized; // TODO - Use trig to set y value to ensure constant speed of ballPosition
			rb.velocity = direction * moveSpeed;
		}
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "bottom") {
			Debug.Log("Game Over");
			Destroy(gameObject);
		}
	}
}
