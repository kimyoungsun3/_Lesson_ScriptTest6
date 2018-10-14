using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace statictest{
	public class EnemyManager : MonoBehaviour {
		
		//-----------------------------
		public class Enemy{
			public static int enemyCount = 0;
			public Enemy(){
				enemyCount ++;
				Debug.Log("Enemy class Create");
			}
		}

		//----------------------------
		void Start () {
			Enemy enemy1 = new Enemy ();
			Enemy enemy2 = new Enemy ();
			Enemy enemy3 = new Enemy ();

			Debug.Log ("enemyCount:" + Enemy.enemyCount);
		}
	}
}
