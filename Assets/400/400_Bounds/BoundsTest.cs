using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoundsTestNameSpace {
	public class BoundsTest : MonoBehaviour {
		BoxCollider2D collder;
		Bounds bounds;
		public bool bUpdate, bExpand;
		void Start() {
			collder = GetComponent<BoxCollider2D>();
			bounds = collder.bounds;
		}

		// Update is called once per frame
		void Update() {
			if (bUpdate)
			{
				bounds = collder.bounds;
			}
			else if (bExpand)
			{
				bExpand = false;
				float _amount = 0.015f * -2;
				Debug.Log(_amount);
				bounds.Expand(_amount);

			}
			Debug.Log(
				bounds.center
				+ ":" + bounds.min
				+ ":" + bounds.max
				+ ":" + bounds.extents
				+ ":" + bounds.size
				+ ":" + bounds.size.x
				);
		}
	}
}
