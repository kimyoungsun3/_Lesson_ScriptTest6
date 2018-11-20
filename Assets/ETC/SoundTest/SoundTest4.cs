using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest4 : MonoBehaviour {
	public AudioClip bg, effect, idle;
	public AudioSource bgSpeak, effectSpeak, engineSpeak;

	void Start(){
		Debug.Log ("1, 2, 3key ");			
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			bgSpeak.clip = bg;
			bgSpeak.loop = true;
			bgSpeak.Play ();
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			effectSpeak.clip = effect;
			effectSpeak.Play ();
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			engineSpeak.clip = idle;
			engineSpeak.loop = true;
			engineSpeak.Play ();
		}
	}
}
