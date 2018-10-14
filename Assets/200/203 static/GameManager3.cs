using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace statictest{
	public class GameManager3 : MonoBehaviour {


		void Start(){
			Debug.Log (" Mouse Click Enemy Spawn");
		}

		void Update(){
			if(Input.GetMouseButtonDown(0)){
				EnemyManager3.InvorkCreateEnemy ();
			}
		}

	}
}
