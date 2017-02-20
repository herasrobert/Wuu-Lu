using UnityEngine;
using System.Collections;

public class CameraBackhgroundColorChange : MonoBehaviour{

	float colorResetTimer = 0f;
	public float maxTimer = 15f;

	Camera cameraComponent;

	void Start(){
		cameraComponent = GetComponent<Camera>();
		cameraComponent.clearFlags = CameraClearFlags.SolidColor;

		//blue
		//cyan
		//grey
		//green
		//magenta
		//red
		//white
		//yellow


	}

	void Update(){
		colorResetTimer -= Time.deltaTime;
		
		if(colorResetTimer < 0){
			resetColor();
			colorResetTimer = maxTimer;
		}
	}

	void resetColor(){
		int randomNumber = (int) Random.Range (0f,9f);
		
		if(randomNumber == 0){
			//Do Nothing
		}else if(randomNumber == 1){
			cameraComponent.backgroundColor = Color.blue;
		}else if(randomNumber == 2){
			cameraComponent.backgroundColor = Color.cyan;
		}else if(randomNumber == 3){
			cameraComponent.backgroundColor = Color.grey;
		}else if(randomNumber == 4){
			cameraComponent.backgroundColor = Color.green;
		}else if(randomNumber == 5){
			cameraComponent.backgroundColor = Color.magenta;
		}else if(randomNumber == 6){
			cameraComponent.backgroundColor = Color.red;
		}else if(randomNumber == 7){
			cameraComponent.backgroundColor = Color.white;
		}else if(randomNumber == 8){
			cameraComponent.backgroundColor = Color.yellow;
		}
	}

}
