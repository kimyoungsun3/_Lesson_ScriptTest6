using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventTest2
{
	public class EventTest_DelegateParam2 : MonoBehaviour
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
				Debug.Log("====[1. first add3 ]=====");
				onParam(1);
			}

			//기존에 더 추가하기...
			onParam += Fun21;
			if (onParam != null)
			{
				Debug.Log("====[2. add 1 ]=====");
				onParam(1);
			}

			//있던 없던 빼기...
			onParam -= Fun21;
			if (onParam != null)
			{
				Debug.Log("====[3. remove 1 ]=====");
				onParam(1);
			}
		}
		int Fun21(int _v) { Debug.Log("Fun21");		return _v; }
		int Fun22(int _v) { Debug.Log("Fun22");		return _v; }
		int Fun23(int _v) { Debug.Log("Fun23");		return _v; }
	}
}
