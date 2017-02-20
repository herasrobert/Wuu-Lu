using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

	public GameObject greenArea;
	GreenAreaController greenAreaControllerScript;
	
	SpriteRenderer spriteRenderer;
	//CircleCollider2D circleCollider;
	PolygonCollider2D polygonCollider;
	GameObject soundController;
	SoundController soundControllerScript;
	void Start(){
		soundController = GameObject.Find ("SoundController");
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		//circleCollider = this.GetComponent<CircleCollider2D>();
		polygonCollider = this.GetComponent<PolygonCollider2D>();
		greenAreaControllerScript = greenArea.GetComponent<GreenAreaController>();
		
		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}
	}
	void Update(){}
	
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			if (soundController != null) {
				soundControllerScript.playSFX("KeySound");
			}
			greenAreaControllerScript.incrementLocks();
			spriteRenderer.enabled = false;//Hide
			polygonCollider.enabled = false;//Disable Box Collider
		}
	}

	public void resetKey(){
		spriteRenderer.enabled = true;//Hide
		polygonCollider.enabled = true;//Disable Box Collider
	}
}

