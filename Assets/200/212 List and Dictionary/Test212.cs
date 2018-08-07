using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test212 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<DataNode> list = new List<DataNode> ();
		list.Add (new DataNode ("Harvey", 50));
		list.Add (new DataNode ("Jonh", 100));
		list.Add (new DataNode ("Pip", 5));
		list.Sort ();

		foreach (DataNode _node in list) {
			Debug.Log (_node.name + " " + _node.power);
		}
		list.Clear ();
	}

}
