using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace statictest{
	public class EnemyManager3 : MonoBehaviour {
		public static EnemyManager3 ins { get; private set; }
		public GameObject enemyPrefab;

		void Awake(){
			ins = this;
		}

		public static void InvorkCreateEnemy(){
			GameObject _go = Instantiate (
				ins.enemyPrefab, 
				ins.transform.position + Random.onUnitSphere * 3f, 
				Quaternion.identity
			);

			_go.transform.SetParent (ins.transform);
		}

	}
}
