using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventTest2
{
	public class EventTest_DelegateParam : MonoBehaviour
	{
		public delegate int INT_FUN_INT(int _v);
		public INT_FUN_INT onParam;

		void Start()
		{
			onParam += Fun21;
			onParam += Fun22;
			onParam += Fun23;

			if (onParam != null)
			{
				Debug.Log(onParam(1));
			}
		}

		int Fun21(int _v) { Debug.Log("Fun21");		return 1; }
		int Fun22(int _v) { Debug.Log("Fun22");		return 2; }
		int Fun23(int _v) { Debug.Log("Fun23");		return 3; }
	}
}
