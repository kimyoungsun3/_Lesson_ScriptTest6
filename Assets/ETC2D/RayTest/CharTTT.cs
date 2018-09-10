using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTTT : MonoBehaviour {
	public float hp = 100;
	bool bDie = false;
	public void TakeDamage(float _f){
		hp -= _f;
		Debug.Log("Damage > " + hp);
		if (hp < 0 && bDie) {
			Die ();
		}
	}

	void Die(){
		gameObject.SetActive (false);
	}
}
