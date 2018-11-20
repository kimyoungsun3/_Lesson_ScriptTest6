using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundTest2 : MonoBehaviour {
	public AudioClip bg, effect;
	public AudioSource bgSpeak;

	void Start(){
		Debug.Log ("1, 2key ");
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			bgSpeak.clip = bg;
			bgSpeak.loop = true;
			bgSpeak.Play ();
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			bgSpeak.clip = effect;
			bgSpeak.Play ();
		}
	}
}
