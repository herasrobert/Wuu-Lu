using UnityEngine;
using System.Collections;

public class CheckPointAdder : MonoBehaviour {

	public int checkPointNumber = 0;

	GameObject levelController;
	LevelController levelControllerScript;	
	GameObject livesController;
	LivesController livesControllerScript;

	void Start(){		
		levelController = GameObject.Find ("LevelController");		
		livesController = GameObject.Find ("LivesController");		

		if(levelController != null){
			levelControllerScript = levelController.GetComponent<LevelController>();
			levelControllerScript.setCheckPointLevel(checkPointNumber);
		}

		if(livesController != null){
			livesControllerScript = livesController.GetComponent<LivesController>();
			livesControllerScript.saveDeaths();//Save Deaths
		}

	}


	void Update(){
	
	}


}
