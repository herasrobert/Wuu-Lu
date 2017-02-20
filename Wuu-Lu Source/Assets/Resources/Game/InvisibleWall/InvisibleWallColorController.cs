using UnityEngine;
using System.Collections;

public class InvisibleWallColorController : MonoBehaviour {

	float colorResetTimer = 0f;
	public float maxTimer = 15f;
	
	public Sprite blueWall;
	public Sprite brownWall;
	public Sprite cyanWall;
	public Sprite goldWall;
	public Sprite greenWall;
	public Sprite greyWall;
	public Sprite orangeWall;
	public Sprite pinkWall;
	public Sprite purpleWall;
	public Sprite yellowWall;

	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		
		resetColor();
		colorResetTimer = maxTimer;
	}
	void Update(){
		colorResetTimer -= Time.deltaTime;
		
		if(colorResetTimer < 0){
			resetColor();
			colorResetTimer = maxTimer;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player"){
			resetColor();
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player"){
			resetColor();
		}
	}
	
	void resetColor(){
		int randomNumber = (int) Random.Range (0f,11f);
		
		if(randomNumber == 0){
			//Do Nothing
		}else if(randomNumber == 1){
			spriteRenderer.sprite = blueWall;
		}else if(randomNumber == 2){
			spriteRenderer.sprite = brownWall;
		}else if(randomNumber == 3){
			spriteRenderer.sprite = cyanWall;
		}else if(randomNumber == 4){
			spriteRenderer.sprite = goldWall;
		}else if(randomNumber == 5){
			spriteRenderer.sprite = greenWall;
		}else if(randomNumber == 6){
			//spriteRenderer.sprite = greyWall;
			//Grey Fireball Blends in with current background too much
		}else if(randomNumber == 7){
			spriteRenderer.sprite = orangeWall;
		}else if(randomNumber == 8){
			spriteRenderer.sprite = pinkWall;
		}else if(randomNumber == 9){
			spriteRenderer.sprite = purpleWall;
		}else if(randomNumber == 10){
			spriteRenderer.sprite = yellowWall;
		}
	}
}
