using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class DictorayTest : MonoBehaviour {
		public Dictionary<int, DataNode> dicDataNode = new Dictionary<int, DataNode> ();


		// Use this for initialization
		void Start () 
		{
			dicDataNode.Add (50, 	new DataNode ("Harvey", 50));
			dicDataNode.Add (100, 	new DataNode ("Jonh", 100));
			dicDataNode.Add (5, 	new DataNode ("Pip", 5));
			Display ();
		}

		void Display()
		{
			foreach (KeyValuePair<int, DataNode> _kv in dicDataNode) 
			{
				Debug.Log (_kv.Key + " " + _kv.Value.ToString());
			}
		}

		void Update(){
			if (Input.GetMouseButtonDown (0)) {
				//1. 넣기 전에 검사.
				int _x = Random.Range (0, 10);
				Debug.Log ("Dictionary Add:" + _x);
				if (!dicDataNode.ContainsKey (_x)) {
					dicDataNode.Add (_x, new DataNode (_x.ToString (), _x));			
				}
			}
			else if (Input.GetMouseButtonDown (1)) 
			{
				//2. 삭제하기 전에 검사.
				int _count = dicDataNode.Count;
				if (_count > 0) {
					int _x = Random.Range (0, _count);
					Debug.Log ("Dictionary Remove:" + _x);
					if (dicDataNode.ContainsKey (_x)) {
						dicDataNode.Remove (_x);
					}
				}
			} 
			else if (Input.GetMouseButtonDown (2)) 
			{
				Display ();
			}
		}
	}
}
