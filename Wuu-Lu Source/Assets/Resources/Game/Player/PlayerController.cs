using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	bool toggleColliderCheatCode = false;

	Vector2 checkPointPosition;

	GameObject livesController;
	LivesController livesControllerScript;
	
	Rigidbody2D body;
	BoxCollider2D boxCollider;
	GameObject greenArea;
	GreenAreaController greenAreaControllerScript;

	GameObject soundController;
	SoundController soundControllerScript;

	void Start(){
		body = this.GetComponent<Rigidbody2D>();
		boxCollider = this.GetComponent<BoxCollider2D>();
		livesController = GameObject.Find("LivesController");
		soundController = GameObject.Find("SoundController");
		greenArea = GameObject.FindGameObjectWithTag("GreenArea");//Reset Green Area

		if(livesController != null){
			livesControllerScript = livesController.GetComponent<LivesController>();
		}
		if(greenArea != null){
			greenAreaControllerScript = greenArea.GetComponent<GreenAreaController>();
		}
		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}

		checkPointPosition = new Vector2(this.transform.position.x, this.transform.position.y);

		if(livesController != null){
			if(Application.loadedLevel == 1){
				livesControllerScript.resetLives(); // Reset lives so LevelOne starts with 0 lives due to CheckPoint Deaths PlayerPref
			}
		}	
	}

	void Update(){
		if(Input.GetKey(KeyCode.K)){
			dead();
		}
		if(Input.GetKeyDown(KeyCode.G)){
			toggleCollider();
		}

	}

	void OnTriggerEnter2D(Collider2D coll){			
		if (coll.gameObject.tag == "Fireball") {
			dead();
		}

		if (coll.gameObject.tag == "CheckPoint") {
			checkPointPosition = new Vector2(coll.transform.position.x, coll.transform.position.y);
		}
		if (coll.gameObject.tag == "FireSquare") {
			dead();
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Spike") {
			dead();
		}
	}

	void dead(){
		if (soundController != null) {
			soundControllerScript.playSFX("DeadSound");
		}
		body.isKinematic = true;
		if (livesController != null) {
			livesControllerScript.addLives ();
		}
		transform.position = new Vector2(checkPointPosition.x, checkPointPosition.y);
		greenAreaControllerScript.resetGreenArea();//Reset Green Area
		resetAllKeys();
		body.isKinematic = false;
	}

	void resetAllKeys(){
		GameObject[] keyObjects = GameObject.FindGameObjectsWithTag ("Key"); // Fina All Keys in Current Level

		for(var i = 0 ; i < keyObjects.Length ; i ++){
			KeyController keyControllerScript = keyObjects[i].GetComponent<KeyController>();
			keyControllerScript.resetKey();
		}
	}

	void toggleCollider(){
		if (toggleColliderCheatCode) {
			toggleColliderCheatCode = false;
			boxCollider.enabled = true;
		} else {
			toggleColliderCheatCode = true;
			boxCollider.enabled = false;
		}
	}

}
