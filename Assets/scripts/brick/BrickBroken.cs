using UnityEngine;

public class BrickBroken : MonoBehaviour {

	[SerializeField]
	private Sprite damagedBrickSprite;

	private SpriteRenderer sprRen;
	private int health = 2;

	private void Awake () {
		sprRen = GetComponent<SpriteRenderer>();
	}

	private void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "ball") {
			TakeDamage();
		}
	}

	private void TakeDamage () {
		health--;
		if (health <= 0) {
			Destroy(gameObject);
		} else {
			sprRen.sprite = damagedBrickSprite;
		}
	}
}
