using UnityEngine;
using System.Collections;

public class LivesController : MonoBehaviour {

	int currentAttempts = 0;

	void Awake(){		
		DontDestroyOnLoad (transform.gameObject);
		
		if (FindObjectsOfType (GetType ()).Length > 1) {// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy (gameObject);
		}
	}

	void Start(){
	
	}

	void Update(){
	
	}
	public void addLives(){
		currentAttempts++;
	}
	public int getLives(){
		return currentAttempts;
	}
	public void saveDeaths(){
		PlayerPrefs.SetInt("Deaths", currentAttempts);
	}
	public void loadDeaths(){
		currentAttempts = PlayerPrefs.GetInt("Deaths");
	}
	public void resetLives(){
		currentAttempts = 0;
	}

}
