using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest3 : MonoBehaviour {
	public AudioClip bg, effect;
	public AudioSource bgSpeak, effectSpeak;

	void Start(){
		Debug.Log ("1, 2key ");
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			bgSpeak.clip = bg;
			bgSpeak.loop = true;
			bgSpeak.Play ();
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			effectSpeak.clip = effect;
			effectSpeak.Play ();
		}
	}
}
