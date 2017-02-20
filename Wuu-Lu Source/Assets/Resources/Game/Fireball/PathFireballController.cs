using UnityEngine;
using System.Collections;

public class PathFireballController : MonoBehaviour {

	public float movementSpeed = 3f;

	public Vector2 pointOne;
	public Vector2 pointTwo;
	public Vector2 pointThree;
	public Vector2 pointFour;
	Vector2 currentPosition;
	
	public bool twoPoint = false;
	public bool threePoint = false;
	public bool fourPoint = false;

	bool reachedPointOne = false;
	bool reachedPointTwo = false;
	bool reachedPointThree = false;
	bool reachedPointFour = false;

	void Start(){
		currentPosition = this.transform.position;
	}

	void Update(){
		currentPosition = this.transform.position;
		if (twoPoint) {
			twoPointPath();
		}else if(threePoint) {
			threePointPath();
		}else if(fourPoint) {
			fourPointPath();
		}
	}	

	void twoPointPath(){
		if(!reachedPointOne){
			moveTo(pointOne);
			if(currentPosition == pointOne){
				reachedPointOne = true;
			}
		}else if(!reachedPointTwo){
			moveTo(pointTwo);
			if(currentPosition == pointTwo){
				reachedPointTwo = true;
				resetBools();
			}
		}
	}

	void threePointPath(){
		if(!reachedPointOne){
			moveTo(pointOne);
			if(currentPosition == pointOne){
				reachedPointOne = true;
			}
		}else if(!reachedPointTwo){
			moveTo(pointTwo);
			if(currentPosition == pointTwo){
				reachedPointTwo = true;
			}
		}else if(!reachedPointThree){
			moveTo(pointThree);
			if(currentPosition == pointThree){
				reachedPointThree = true;
				resetBools();
			}
		}
	}

	void fourPointPath(){
		if(!reachedPointOne){
			moveTo(pointOne);
			if(currentPosition == pointOne){
				reachedPointOne = true;
			}
		}else if(!reachedPointTwo){
			moveTo(pointTwo);
			if(currentPosition == pointTwo){
				reachedPointTwo = true;
			}
		}else if(!reachedPointThree){
			moveTo(pointThree);
			if(currentPosition == pointThree){
				reachedPointThree = true;
			}
		}else if(!reachedPointFour){
			moveTo(pointFour);
			if(currentPosition == pointFour){
				reachedPointFour = true;
				resetBools();
			}
		}
	}



	void moveTo(Vector2 point){
		this.transform.position = Vector2.MoveTowards(transform.position, point, movementSpeed * Time.deltaTime);
	}

	void resetBools(){
		reachedPointOne = false;
		reachedPointTwo = false;
		reachedPointThree = false;
		reachedPointFour = false;
	}

}
