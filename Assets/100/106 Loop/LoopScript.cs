using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log ("for, foreach...");

		string[] books = { "A book", "B book", "C book"};

		for (int i = 0; i < books.Length; i++) {
			Debug.Log ("for:" + books [i]);
		}

		foreach (string _str in books) {
			Debug.Log ("foreach:" + _str);
		}

		int j = 0;
		while (j < books.Length) {
			Debug.Log ("while:" + books [j]);
			j++;
		}
		
	}

}
