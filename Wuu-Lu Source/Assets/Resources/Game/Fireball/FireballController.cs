using UnityEngine;
using System.Collections;

public class FireballController : MonoBehaviour {
	public float movementSpeed = 3f;
	
	public bool horizontal;
	bool rebound = false;
	
	Vector2 startingPoint;
	public Vector2 endingPoint;
	
	void Start(){
		startingPoint = new Vector2 (this.transform.position.x, this.transform.position.y);			
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
			if(this.transform.position.x < endingPoint.x){
				this.transform.Translate (Vector2.right * movementSpeed * Time.deltaTime);
				//transform.localScale = new Vector3 (1, 1, 1);
			}else{
				rebound = true;
			}
		} else {
			if(this.transform.position.x > startingPoint.x){	
				this.transform.Translate (-Vector2.right * movementSpeed * Time.deltaTime);
				//transform.localScale = new Vector3 (-1, 1, 1);
			}else{
				rebound = false;
			}
		}
	}
	
	void verticalMovement(){
		if (rebound == false) {
			if(this.transform.position.y < endingPoint.y){
				this.transform.Translate (Vector2.up * movementSpeed * Time.deltaTime); // Move Up
				//transform.localScale = new Vector3 (1, 1, 1);
			}else{
				rebound = true;
			}
		} else {
			if(this.transform.position.y > startingPoint.y){	
				this.transform.Translate (-Vector2.up * movementSpeed * Time.deltaTime); // Move Down
				//transform.localScale = new Vector3 (1, -1, 1);
			}else{
				rebound = false;
			}
		}
	}
	
	
}
