using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticTest {
	public class StaticTest : MonoBehaviour {
		void Start() {
			Debug.Log(Util.Add(1, 2));
		}


		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				Debug.Log("StaticAAA:" + StaticAAA.ins.name);
				StaticAAA.ins.GetComponent<MeshRenderer>().material.color = Color.green;
			}
			else if(Input.GetKeyDown(KeyCode.Alpha2))
			{
				Debug.Log("StaticBBB:" + StaticBBB.ins.name);
				StaticBBB.ins.GetComponent<MeshRenderer>().material.color = Color.green;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				Debug.Log("StaticCCC:" + StaticCCC.dic_Item.Count);
				//StaticCCC.ins.GetComponent<MeshRenderer>().material.color = Color.green;
			}

		}
	}
}