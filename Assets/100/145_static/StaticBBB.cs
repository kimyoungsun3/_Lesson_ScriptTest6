using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticTest
{
	public class StaticBBB : MonoBehaviour
	{
		public static StaticBBB ins;
		void Start(){	ins = this;}
	}
}