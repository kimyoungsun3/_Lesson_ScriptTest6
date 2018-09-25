using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraryTest{
	public class ArraryTest : MonoBehaviour {
		public int[] arr1 = new int[3];
		public int[] arr2 = { 1, 2, 3 };

		public GameObject[] arrGos;
		public List<GameObject> listGos = new List<GameObject> ();
		public List<GameObject> listGos2;
		public Dictionary<GameObject, XXX> dicGos = new Dictionary<GameObject, XXX> ();

		void Start(){
			GameObject[] _gos = GameObject.FindGameObjectsWithTag ("Player");

			arrGos = new GameObject[_gos.Length];
			for (int i = 0; i < _gos.Length; i++) 
			{
				//array -> 데이타 카피해주기 (직접연결하면 레퍼런스로 가서 공유된다.).
				arrGos [i] = _gos [i];

				//array -> list
				listGos.Add(_gos [i]);

				//array -> dictionary
				XXX _x = new XXX (i, _gos[i]);
				dicGos.Add(_gos[i], _x);
			}

			//array -> list 직접생성...
			listGos2 = new List<GameObject> (_gos);
		}


		public class XXX{
			public GameObject go;
			public int idx;

			public XXX( int _idx, GameObject _go ){
				go = _go;
				idx = _idx;
			}
		}
	}
}
