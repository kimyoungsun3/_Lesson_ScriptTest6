using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticTest
{
	public class StaticCCCSub : MonoBehaviour
	{
		void Start()
		{
			StaticCCC.dic_Item.Add(StaticCCC.dicIndex++, gameObject);
		}
	}
}
