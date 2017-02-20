using UnityEngine;
using System.Collections;

public class PlayerHUD : MonoBehaviour {

	int currentLevelNumber = 0;

	public Texture hudBackground;
	public Texture soundNoteOnButton;
	public Texture soundNoteOffButton;
	public Texture musicNoteOnButton;
	public Texture musicNoteOffButton;
	//public Texture thisLevelMessage;
	
	GameObject livesController;
	LivesController livesControllerScript;
	GameObject soundController;
	SoundController soundControllerScript;

	GUIStyle guiStyle;


	void Start(){
		livesController = GameObject.Find ("LivesController");
		soundController = GameObject.Find ("SoundController");

		if(livesController != null){
			livesControllerScript = livesController.GetComponent<LivesController>();
		}	

		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}

		guiStyle = new GUIStyle();
		guiStyle.fontSize = 18;
		guiStyle.normal.textColor = Color.white;
		currentLevelNumber = Application.loadedLevel;
	}

	void Update(){
	
	}
	public int x = 892;
	public int y = 13;
	public int i = 65;
	public int j = 40; 
	void OnGUI(){
		/*
		if(thisLevelMessage != null){
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), thisLevelMessage, ScaleMode.StretchToFill);
		}*/
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), hudBackground, ScaleMode.StretchToFill);	

		
		if(livesController != null){
			GUI.Label(new Rect(60, 23, 100, 18), "Deaths: "+ livesControllerScript.getLives(), guiStyle);//Draw Deaths
		}

		if (GUI.Button (new Rect (892, 13, 65, 40), "", GUIStyle.none)){//Draw Menu Button
			if (soundController != null) {
				soundControllerScript.playSFX("ButtonClick");
			}
			Application.LoadLevel("MainMenu");
		}

		//Draw Pause Button - If Pause will be used

		if (soundController != null) {		
			if (soundControllerScript.getSound () == 1) {
				if (GUI.Button (new Rect (860, 20, 30, 30), soundNoteOnButton, GUIStyle.none)) {//Sound Button
					/*if (soundController != null) {
						soundControllerScript.playSFX ("ButtonClick");
					}*/
					soundControllerScript.toggleSound ();
				}
			} else {
				if (GUI.Button (new Rect (860, 20, 30, 30), soundNoteOffButton, GUIStyle.none)) {//Sound Button
					soundControllerScript.toggleSound ();
					if (soundController != null){
						soundControllerScript.playSFX ("ButtonClick");
					}
				}
			}

			if (soundControllerScript.getMusic () == 1) {
				if (GUI.Button (new Rect (820, 20, 30, 30), musicNoteOnButton, GUIStyle.none)) {//Sound Button
					if (soundController != null) {
						soundControllerScript.playSFX("ButtonClick");
					}
					soundControllerScript.toggleMusic();
				}
			} else {
				if (GUI.Button (new Rect (820, 20, 30, 30), musicNoteOffButton, GUIStyle.none)) {//Sound Button
					soundControllerScript.toggleMusic();
					if (soundController != null) {
						soundControllerScript.playSFX("ButtonClick");
					}
				}
			}

		}

		GUI.Label(new Rect(155, 23, 100, 18), "Level: "+ currentLevelNumber, guiStyle);//Draw Deaths
	}


}

