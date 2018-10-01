using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstantiateTest{
	public class Enemy : MonoBehaviour {
		public float hp = 100f;

		public void TakeDamage(float _damange){
			hp -= _damange;
			if (hp <= 0f) {
				Destroy (gameObject);
			}
		}
	}
}
