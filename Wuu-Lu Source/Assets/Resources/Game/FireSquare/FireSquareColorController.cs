using UnityEngine;
using System.Collections;

public class FireSquareColorController : MonoBehaviour {

	
	float colorResetTimer = 0f;
	public float maxTimer = 15f;
	
	public Sprite blueFireSquare;
	public Sprite brownFireSquare;
	public Sprite cyanFireSquare;
	public Sprite goldFireSquare;
	public Sprite greenFireSquare;
	public Sprite greyFireSquare;
	public Sprite orangeFireSquare;
	public Sprite pinkFireSquare;
	public Sprite purpleFireSquare;
	public Sprite yellowFireSquare;
	
	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		
		resetColor();
		
		//spriteRenderer.transform.localScale = new Vector3(.75f, .750f, 1.0f);
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
	
	void resetColor(){
		int randomNumber = (int) Random.Range (0f,11f);
		
		if(randomNumber == 0){
			//Do Nothing
		}else if(randomNumber == 1){
			spriteRenderer.sprite = blueFireSquare;
		}else if(randomNumber == 2){
			spriteRenderer.sprite = brownFireSquare;
		}else if(randomNumber == 3){
			spriteRenderer.sprite = cyanFireSquare;
		}else if(randomNumber == 4){
			spriteRenderer.sprite = goldFireSquare;
		}else if(randomNumber == 5){
			spriteRenderer.sprite = greenFireSquare;
		}else if(randomNumber == 6){
			//spriteRenderer.sprite = greyFireSquare;
			//Grey FireSquare Blends in with current background too much
		}else if(randomNumber == 7){
			spriteRenderer.sprite = orangeFireSquare;
		}else if(randomNumber == 8){
			spriteRenderer.sprite = pinkFireSquare;
		}else if(randomNumber == 9){
			spriteRenderer.sprite = purpleFireSquare;
		}else if(randomNumber == 10){
			spriteRenderer.sprite = yellowFireSquare;
		}
	}
}
