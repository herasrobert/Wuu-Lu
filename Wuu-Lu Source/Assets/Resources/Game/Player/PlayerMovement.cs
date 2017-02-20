using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float movementSpeed = 3f;

	Rigidbody2D body;

	void Start(){
		body = this.GetComponent<Rigidbody2D>();	
	}

	void Update(){
		Vector3 vel = new Vector3();		
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
			Vector3 velUp = new Vector3();
			// just use 1 to set the direction.
			velUp.y = 1;
			vel += velUp;
		}
		else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
			Vector3 velDown = new Vector3();
			velDown.y = -1;
			vel += velDown;
		}		
		// no else here. Combinations of up/down and left/right are fine.
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
			Vector3 velLeft = new Vector3();
			velLeft.x = -1;
			vel += velLeft;
		}
		else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
			Vector3 velRight = new Vector3();
			velRight.x = 1;
			vel += velRight;
		}		
		// check if player wants to move at all. Don't check exactly for 0 to avoid rounding errors
		// (magnitude will be 0, 1 or sqrt(2) here)
		if (vel.magnitude > 0.001) {
			Vector3.Normalize(vel);
			vel *= movementSpeed;
			body.velocity = vel;
		}



	}




}
