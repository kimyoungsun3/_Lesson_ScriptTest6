using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraryTest{
	public class FindTest : MonoBehaviour {
		GameObject player;
		float[] t = new float[10];
		public int LOOP_MAX = 1000;

		void Update(){
			t [0] = Time.realtimeSinceStartup;
			FunSingleTone ();
			t [1] = Time.realtimeSinceStartup;
			FunSingleTone2 ();
			t [2] = Time.realtimeSinceStartup;
			FindGameObjectWithTag ();
			t [3] = Time.realtimeSinceStartup;
			FunFind ();
			t [4] = Time.realtimeSinceStartup;
			FunFindObjectOfType ();
			t [5] = Time.realtimeSinceStartup;



			Debug.Log ("=========================");
			Debug.Log ("FunSingleTone :" 			+ (t [1] - t [0]));
			Debug.Log ("FunSingleTone2 :" 			+ (t [2] - t [1]));
			Debug.Log ("FindGameObjectWithTag :" 	+ (t [3] - t [2]));
			Debug.Log ("FunFind :" 					+ (t [4] - t [3]));
			Debug.Log ("FunFindObjectOfType :" 		+ (t [5] - t [4]));
		}

		void FunFind(){
			for (int i = 0; i < LOOP_MAX; i++) {
				player = GameObject.Find ("Player");
			}
		}

		void FindGameObjectWithTag(){
			for (int i = 0; i < LOOP_MAX; i++) {
				player = GameObject.FindGameObjectWithTag ("Player");
			}
		}

		void FunFindObjectOfType(){
			for (int i = 0; i < LOOP_MAX; i++) {
				player = (GameObject)GameObject.FindObjectOfType (typeof(GameObject));
			}
		}

		void FunSingleTone(){
			for (int i = 0; i < LOOP_MAX; i++) {
				player = Player.ins.gameObject;
			}
		}

		void FunSingleTone2(){
			for (int i = 0; i < LOOP_MAX; i++) {
				player = Player.ins.go;
			}
		}
	}
}
