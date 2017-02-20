using UnityEngine;
using System.Collections;

public class ReboundFireballController : MonoBehaviour {
	public float movementSpeed = 3f;
	
	public bool horizontal;	
	bool rebound = false;
	
	//SpriteRenderer renderer;
	void Start(){
		//renderer = this.GetComponent<SpriteRenderer>();
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag != "Player" && coll.gameObject.tag != "Fireball" && coll.gameObject.tag != "Key"){
			toggleRebound();
		}
	}

	void Update(){
		if (horizontal) {
			horizontalMovement();
		} else {
			verticalMovement();
		}
	}
	void horizontalMovement(){
		if (rebound == false) {
			this.transform.Translate (Vector2.right * movementSpeed * Time.deltaTime);
			//transform.localScale = new Vector3 (1, 1, 1);
		} else {
			this.transform.Translate (-Vector2.right * movementSpeed * Time.deltaTime);
			//transform.localScale = new Vector3 (-1, 1, 1);
		}
	}
	
	void verticalMovement(){
		if (rebound == false) {
			this.transform.Translate (Vector2.up * movementSpeed * Time.deltaTime); // Move Up
			//transform.localScale = new Vector3 (1, 1, 1);
		} else {
			this.transform.Translate (-Vector2.up * movementSpeed * Time.deltaTime); // Move Down
			//transform.localScale = new Vector3 (1, -1, 1);
		}
	}
	
	void toggleRebound(){
		if (rebound) {
			rebound = false;
		} else {
			rebound = true;
		}
	}
}
