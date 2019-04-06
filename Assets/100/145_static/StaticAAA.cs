using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticTest
{
	public class StaticAAA : MonoBehaviour
	{
		public static StaticAAA ins;
		void Start(){	ins = this;}
	}
}
