using UnityEngine;
using System.Collections;

public class InstructionsSceneController : MonoBehaviour {
	
	GameObject soundController;
	SoundController soundControllerScript;

	public Texture instructionsSceneBackground;
	public Texture playButtonTexture;

	void Start(){
		soundController = GameObject.Find ("SoundController");

		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}
	}


	void Update(){
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), instructionsSceneBackground, ScaleMode.StretchToFill);

		if (GUI.Button (new Rect (452, 615, 120, 30), "Let's Go!")){
			if (soundController != null) {
				soundControllerScript.playSFX("ButtonClick");
			}
			Application.LoadLevel("LevelOne");
		}

		if (GUI.Button (new Rect (892, 13, 65, 40), "", GUIStyle.none)){
			if (soundController != null) {
				soundControllerScript.playSFX("ButtonClick");
			}
			Application.LoadLevel("MainMenu");
		}

	}
}
