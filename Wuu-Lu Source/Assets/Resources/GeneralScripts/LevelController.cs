using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {
	int checkPointLevel = 0;

	GameObject livesController;
	LivesController livesControllerScript;

	void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}

	void Start(){
		livesController = GameObject.Find ("LivesController");
		
		if(livesController != null){
			livesControllerScript = livesController.GetComponent<LivesController>();
		}	

		if (PlayerPrefs.HasKey ("CheckPointLevel")) {
			checkPointLevel = PlayerPrefs.GetInt("CheckPointLevel");
		}
	}

	void Update(){
	
	}

	public int getCurrentCheckPoint(){
		return checkPointLevel;
	}

	public void resetLevels(){
		checkPointLevel = 1;
		PlayerPrefs.SetInt("CheckPointLevel", checkPointLevel);
	}

	public void loadLatestLevel(){
		/*if(currentLevel == 0){
			Application.LoadLevel ("MainMenu");
		}else if (currentLevel == 1) {
			Application.LoadLevel ("IntroLevel");
		}else if (currentLevel == 2){
			Application.LoadLevel("WorldSelect");		
		}*/
	}
	public void setCheckPointLevel(int level){
		checkPointLevel = level;
		PlayerPrefs.SetInt("CheckPointLevel", checkPointLevel);
	}
	public void LoadLevel(int Level){
		/*if(currentLevel == 0){
			Application.LoadLevel ("MainMenu");
		}else if (currentLevel == 1) {
			Application.LoadLevel ("IntroLevel");
		}else if (currentLevel == 2) {
			Application.LoadLevel("WorldSelect");		
		}*/
	}

	public void loadCheckPointLevel(){
		if (checkPointLevel == 10) {
			Application.LoadLevel ("LevelTen");
		} else if (checkPointLevel == 20) {
			Application.LoadLevel ("LevelTwenty");
		}

		if(livesController != null){
			livesControllerScript.loadDeaths();
		}	
	}

	public void loadNextLevel(){
		if(Application.loadedLevelName.Equals("MainMenu")){
			Application.LoadLevel("Instructions");
		}else if(Application.loadedLevelName.Equals("Instructions")){
			Application.LoadLevel("LevelOne");
		}else if(Application.loadedLevelName.Equals("LevelOne")){
			Application.LoadLevel("LevelTwo");
		}else if(Application.loadedLevelName.Equals("LevelTwo")){
			Application.LoadLevel("LevelThree");
		}else if(Application.loadedLevelName.Equals("LevelThree")){
			Application.LoadLevel("LevelFour");
		}else if(Application.loadedLevelName.Equals("LevelFour")){
			Application.LoadLevel("LevelFive");
		}else if(Application.loadedLevelName.Equals("LevelFive")){
			Application.LoadLevel("LevelSix");
		}else if(Application.loadedLevelName.Equals("LevelSix")){
			Application.LoadLevel("LevelSeven");
		}else if(Application.loadedLevelName.Equals("LevelSeven")){
			Application.LoadLevel("LevelEight");
		}else if(Application.loadedLevelName.Equals("LevelEight")){
			Application.LoadLevel("LevelNine");
		}else if(Application.loadedLevelName.Equals("LevelNine")){
			Application.LoadLevel("LevelTen");
		}else if(Application.loadedLevelName.Equals("LevelTen")){
			Application.LoadLevel("LevelEleven");
		}else if(Application.loadedLevelName.Equals("LevelEleven")){
			Application.LoadLevel("LevelTwelve");
		}else if(Application.loadedLevelName.Equals("LevelTwelve")){
			Application.LoadLevel("LevelThirteen");
		}else if(Application.loadedLevelName.Equals("LevelThirteen")){
			Application.LoadLevel("LevelFourteen");
		}else if(Application.loadedLevelName.Equals("LevelFourteen")){
			Application.LoadLevel("LevelFifteen");
		}else if(Application.loadedLevelName.Equals("LevelFifteen")){
			Application.LoadLevel("LevelSixteen");
		}else if(Application.loadedLevelName.Equals("LevelSixteen")){
			Application.LoadLevel("LevelSeventeen");
		}else if(Application.loadedLevelName.Equals("LevelSeventeen")){
			Application.LoadLevel("LevelEighteen");
		}else if(Application.loadedLevelName.Equals("LevelEighteen")){
			Application.LoadLevel("LevelNineteen");
		}else if(Application.loadedLevelName.Equals("LevelNineteen")){
			Application.LoadLevel("LevelTwenty");
		}else if(Application.loadedLevelName.Equals("LevelTwenty")){
			Application.LoadLevel("LevelTwentyOne");
		}else if(Application.loadedLevelName.Equals("LevelTwentyOne")){
			Application.LoadLevel("LevelTwentyTwo");
		}else if(Application.loadedLevelName.Equals("LevelTwentyTwo")){
			Application.LoadLevel("LevelTwentyThree");
		}else if(Application.loadedLevelName.Equals("LevelTwentyThree")){
			Application.LoadLevel("LevelTwentyFour");
		}else if(Application.loadedLevelName.Equals("LevelTwentyFour")){
			Application.LoadLevel("LevelTwentyFive");
		}
	}
}
