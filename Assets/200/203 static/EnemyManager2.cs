using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace statictest{
	public class EnemyManager2 : MonoBehaviour {
		public static EnemyManager2 ins { get; private set; }
		public GameObject enemyPrefab;
		[HideInInspector] public int count;

		void Awake(){
			ins = this;
		}

		public void InvorkCreateEnemy(){
			if (count > 10)
				return;

			count++;
			GameObject _go = Instantiate (enemyPrefab, transform.position + Random.onUnitSphere * 3f, Quaternion.identity);
			_go.transform.SetParent (transform);
		}
	}
}
