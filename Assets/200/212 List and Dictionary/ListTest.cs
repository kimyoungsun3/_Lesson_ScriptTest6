using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class ListTest: MonoBehaviour {
		public List<DataNode> listDataNode = new List<DataNode> ();
		

		// Use this for initialization
		void Start () {
			listDataNode.Add (new DataNode ("Harvey", 50));
			listDataNode.Add (new DataNode ("Jonh", 100));
			listDataNode.Add (new DataNode ("Pip", 5));
			listDataNode.Sort ();
			Display ();
		}

		void Display(){
			foreach (DataNode _node in listDataNode) {
				Debug.Log (_node.name + " " + _node.power);
			}
		}

		void Update(){
			if (Input.GetMouseButtonDown (0)) {
				int _x = Random.Range (0, 10);
				listDataNode.Add (new DataNode (_x.ToString (), _x));
			} else if (Input.GetMouseButtonDown (1)) {
				int _count = listDataNode.Count;
				if (_count > 0) {
					int _idx = Random.Range (0, _count);
					listDataNode.RemoveAt (_idx);
				}
			} else if (Input.GetMouseButtonDown (2)) {
				listDataNode.Sort ();
				Display ();
			}
		}
	}
}
