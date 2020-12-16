using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _301_StencilTest
{
	public class StencilObjectTest : MonoBehaviour
	{
		Material material;
		public int stencilRef = 0;
		int stencilRef2 = -1;
		TextMesh text;
		// Use this for initialization
		void Start()
		{
			material = GetComponent<Renderer>().material;
			text = GetComponentInChildren<TextMesh>();
			
			SetStencilRef();
		}

		void SetStencilRef()
		{
			if (stencilRef == stencilRef2) return;
			stencilRef2 = stencilRef;
			material.SetInt("_StencilRef", stencilRef2);
			gameObject.name = "mask " + stencilRef2.ToString();
			if (text != null)
				text.text = "mask " + stencilRef2.ToString();
		}

		private void Update()
		{
			SetStencilRef();
		}
	}
}