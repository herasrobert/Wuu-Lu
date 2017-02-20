using UnityEngine;
using System.Collections;

public class CreditSceneController : MonoBehaviour {

	public Texture creditSceneBackground;
	
	GameObject soundController;
	SoundController soundControllerScript;

	void Start(){
		soundController = GameObject.Find ("SoundController");

		if(soundController != null){
			soundControllerScript = soundController.GetComponent<SoundController>();
		}
	
	}

	void Update(){
	
	}

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), creditSceneBackground, ScaleMode.StretchToFill);
	
		if (GUI.Button (new Rect (892, 13, 65, 40), "", GUIStyle.none)) {
			if (soundController != null) {
				soundControllerScript.playSFX("ButtonClick");
			}
			Application.LoadLevel("MainMenu");
		}
	}
}
