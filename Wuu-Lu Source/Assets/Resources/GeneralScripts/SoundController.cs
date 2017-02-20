using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	int sound = 1;
	int music = 1;
	
	AudioSource[] audioSource;
	AudioSource buttonClick;
	AudioSource deadSound;
	AudioSource goalSound;
	AudioSource keySound;
	AudioSource invisibleWallCollisionSound;
	AudioSource fakeHalosMusic;
	AudioSource emulsionMusic;
	
	
	void Start () {
		audioSource = GetComponents<AudioSource>();
		buttonClick = audioSource[0];
		deadSound = audioSource[1];		
		goalSound = audioSource[2];
		keySound = audioSource[3];
		invisibleWallCollisionSound = audioSource[4];
		fakeHalosMusic  = audioSource[5];
		emulsionMusic  = audioSource[6];
		/*if (PlayerPrefs.HasKey("Sound") == false) {			
			PlayerPrefs.SetInt ("Sound", 1);
		} else {
			sound = PlayerPrefs.GetInt("Sound");
		}*/
		
		playRandomMusic();
	}
	
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		
		if (FindObjectsOfType(GetType()).Length > 1){// Prevent Duplicated of this GameObject due to DontDestroyOnLoad
			Destroy(gameObject);
		}
	}
	
	void Update () {
		
	}
	
	public void playSFX(string sfx){
		if (sound == 1) {		
			if (sfx.Equals ("ButtonClick")) {
				buttonClick.Play();
			}else if (sfx.Equals ("DeadSound")) {
				deadSound.Play();
			}else if (sfx.Equals ("GoalSound")) {
				goalSound.Play();
			}else if (sfx.Equals ("KeySound")) {
				keySound.Play();
			}else if (sfx.Equals ("InvisbleWallCollision")) {
				invisibleWallCollisionSound.Play();
			}
		}
	}
	public void stopSFX(string sfx){
		/*if (sfx.Equals ("heartbeat")) {
			heartbeat.Stop();//AWS Play
		}else if (sfx.Equals ("SecondaryLaserSounds")) {
			secondaryLaserSounds.Stop();
		}else{
			Debug.Log("Piece: "+sfx+" not found in If Statement.");
		}*/
	}

	public void playSFXOnce(string sfx){
		
	}
	
	public void playMusic(string piece){
		/*if(music == 1){			
			if (piece.Equals ("backgroundMusic")) {
				backgroundMusic.Play();
			}
		}*/
	}

	public void playRandomMusic(){
		stopAllMusic();
		if(music == 1){
			int randomPiece = (int) Random.Range(0f, 2f);
			
			if (randomPiece == 0) {
				fakeHalosMusic.Play();
				Invoke("playRandomMusic", fakeHalosMusic.clip.length);
			} else if (randomPiece == 1){
				emulsionMusic.Play();
				Invoke("playRandomMusic", emulsionMusic.clip.length);
			}
		}
	}

	public void stopMusic(string piece){
		/*if (piece.Equals("backgroundMusic")) {
			audio[5].Stop();
		}*/
	}

	public void stopAllMusic(){
		for(int x = 5; x <= audioSource.Length-1; x++){
			audioSource[x].Stop();
		}
		//audioSource[5].Stop();
		//audioSource[6].Stop();
	}
	
	public void setSoundOn(){
		sound = 1;
	}
	public void setSoundOff(){
		/*sound = 0;
		for(int x = 0; x<= audio.Length-1; x++){
			if(x != 5){ // Skip 5 because 5 is the background music not a sound
				audio[x].Stop();
			}
		}*/
	}
	public int getSound(){
		return sound;
	}
	public void setMusicOn(){
		music = 1;
	}
	public void setMusicOff(){
		music = 0;
	}
	public int getMusic(){
		return music;
	}

	public void toggleSound(){
		if (sound == 1) {
			sound = 0;
		} else {
			sound = 1;
		}	
	}

	public void toggleMusic(){
		if (music == 1) {
			music = 0;
			stopAllMusic();
		} else {
			music = 1;
			playRandomMusic();
		}
	}
}
