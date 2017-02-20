using UnityEngine;
using System.Collections;

public class InvisibleWallController : MonoBehaviour {

	GameObject soundController;
	SoundController soundControllerScript;

	SpriteRenderer spriteRenderer;
	void Start () {
		spriteRenderer = this.GetComponent<SpriteRenderer>();		
		soundController = GameObject.Find ("SoundController");

		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}
		spriteRenderer.enabled = false; //Turn "Invisible"
	}

	void Update(){}	

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player"){
			if (soundController != null) {
				soundControllerScript.playSFX("InvisbleWallCollision");
			}
			spriteRenderer.enabled = true;
		}
	}
}
