using UnityEngine;
using System.Collections;

public class GreenAreaController : MonoBehaviour {

	public int howManyLocks = 0;
	public bool locked = true;
	int maxLocks = 0;
	bool wasLocked = false;

	GameObject levelController;
	LevelController levelControllerScript;
	
	GameObject soundController;
	SoundController soundControllerScript;

	void Start(){		
		soundController = GameObject.Find ("SoundController");
		levelController = GameObject.Find ("LevelController");

		if(levelController != null){
			levelControllerScript = levelController.GetComponent<LevelController>();
		}
		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}

		checkForUnlock();
		maxLocks = howManyLocks;
		wasLocked = locked;
	}

	void Update(){
		if(Input.GetKey(KeyCode.KeypadPlus)){
			if(levelController != null){
				levelControllerScript.loadNextLevel();
			}
		}
	}

	
	void OnTriggerEnter2D(Collider2D coll){		
		if (coll.gameObject.tag == "Player"){
			if(!locked){
				if(levelController != null){
					if (soundController != null) {
						soundControllerScript.playSFX("GoalSound");
					}
					levelControllerScript.loadNextLevel();
				}
			}
		}
	}	

	void OnTriggerStay2D(Collider2D coll){		
		if (coll.gameObject.tag == "Player"){
			if(!locked){
				if(levelController != null){
					if (soundController != null) {
						soundControllerScript.playSFX("GoalSound");
					}
					levelControllerScript.loadNextLevel();
				}
			}
		}
	}

	public void unlock(){
		locked = false;
	}
	public void incrementLocks(){
		howManyLocks--;
		checkForUnlock();
	}

	public void resetGreenArea(){
		howManyLocks = maxLocks;
		locked = wasLocked;
		checkForUnlock();
	}

	void checkForUnlock(){
		if(howManyLocks <= 0){
			locked = false;
		}
	}
}
