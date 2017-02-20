using UnityEngine;
using System.Collections;

public class FireballColorScript : MonoBehaviour {

	float colorResetTimer = 0f;
	public float maxTimer = 15f;

	public Sprite blueFireball;
	public Sprite brownFireball;
	public Sprite cyanFireball;
	public Sprite goldFireball;
	public Sprite greenFireball;
	public Sprite greyFireball;
	public Sprite orangeFireball;
	public Sprite pinkFireball;
	public Sprite purpleFireball;
	public Sprite yellowFireball;

	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = this.GetComponent<SpriteRenderer>();

		resetColor();

		spriteRenderer.transform.localScale = new Vector3(.75f, .750f, 1.0f);
		colorResetTimer = maxTimer;
	}

	void Update(){
		colorResetTimer -= Time.deltaTime;

		if(colorResetTimer < 0){
			resetColor();
			colorResetTimer = maxTimer;
		}
	}

	void resetColor(){
		int randomNumber = (int) Random.Range (0f,11f);
		
		if(randomNumber == 0){
			//Do Nothing
		}else if(randomNumber == 1){
			spriteRenderer.sprite = blueFireball;
		}else if(randomNumber == 2){
			spriteRenderer.sprite = brownFireball;
		}else if(randomNumber == 3){
			spriteRenderer.sprite = cyanFireball;
		}else if(randomNumber == 4){
			spriteRenderer.sprite = goldFireball;
		}else if(randomNumber == 5){
			spriteRenderer.sprite = greenFireball;
		}else if(randomNumber == 6){
			//spriteRenderer.sprite = greyFireball;
			//Grey Fireball Blends in with current background too much
		}else if(randomNumber == 7){
			spriteRenderer.sprite = orangeFireball;
		}else if(randomNumber == 8){
			spriteRenderer.sprite = pinkFireball;
		}else if(randomNumber == 9){
			spriteRenderer.sprite = purpleFireball;
		}else if(randomNumber == 10){
			spriteRenderer.sprite = yellowFireball;
		}
	}
}
