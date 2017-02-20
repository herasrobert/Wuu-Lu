using UnityEngine;
using System.Collections;

public class RotatingFireballController : MonoBehaviour {

	public float rotationSpeeed = 1f;

	void Start(){}

	void Update(){
		transform.Rotate(0,0,rotationSpeeed);
	}
}
