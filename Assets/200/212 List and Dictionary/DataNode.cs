using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	[System.Serializable]
	public class DataNode : IComparable<DataNode> {

		public string name;
		public int power;

		public DataNode(string _n, int _p){
			name = _n;
			power = _p;
		}

		public int CompareTo(DataNode _node){
			if (_node == null) {
				Debug.Log (name);
				return -1;
			}
			Debug.Log (name + " " + _node.name + " => " + (power - _node.power));
			return power - _node.power;
		}

		public override string ToString ()
		{
			return string.Format ("name:{0} power{1}", name, power);
		}
	}
}
