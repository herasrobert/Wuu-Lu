using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	int checkPointLevel = 0;
	public Texture mainMenuBackground;

	//GameObject livesController;
	//LivesController livesControllerScript;
	GameObject levelController;
	LevelController levelControllerScript;
	GameObject soundController;
	SoundController soundControllerScript;

	public Texture playButtonTexture;
	public Texture continueButtonTexture;
	void Start(){
		Application.targetFrameRate = 60; // Set FrameRate to 60
		//livesController = GameObject.Find ("LivesController");
		//livesControllerScript = livesController.GetComponent<LivesController>();
		levelController = GameObject.Find ("LevelController");
		levelControllerScript = levelController.GetComponent<LevelController>();
		
		soundController = GameObject.Find ("SoundController");
		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}

		checkPointLevel = levelControllerScript.getCurrentCheckPoint ();
	}
	
	void Update(){
		
	}
	public int x = 10;
	public int y = 10;
	public int i = 10;
	public int j = 10;

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), mainMenuBackground, ScaleMode.StretchToFill);

		if (GUI.Button (new Rect (452, 369, 120, 30), "Play")) {
			soundControllerScript.playSFX("ButtonClick");			
			Application.LoadLevel("Instructions");
		}

		if(checkPointLevel == 10 || checkPointLevel == 20){		
			if (GUI.Button (new Rect (452, 419, 120, 30), "Continue")){
				soundControllerScript.playSFX("ButtonClick");				
				levelControllerScript.loadCheckPointLevel();
			}
		}

		if (GUI.Button (new Rect (452, 469, 120, 30), "Exit")){
			soundControllerScript.playSFX("ButtonClick");				
			Application.Quit();
		}

		if (GUI.Button (new Rect (5, 740, 75, 25), "", GUIStyle.none)){ //Credits Button
			soundControllerScript.playSFX("ButtonClick");			
			Application.LoadLevel("Credits");
		}



		


		/*if (GUI.Button (new Rect (300, 300, 100, 50), "Clear")) {
			PlayerPrefs.DeleteAll();
			levelControllerScript.resetLevels();
			//livesControllerScript.resetLives();
			Start();
		}*/
		
		
	}



}
