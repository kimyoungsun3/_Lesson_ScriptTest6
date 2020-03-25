using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionaryTest
{
	public class GClass : MonoBehaviour
	{
		public void Move(Vector3 _move)
		{
			transform.Translate(_move);
		}
	}
}