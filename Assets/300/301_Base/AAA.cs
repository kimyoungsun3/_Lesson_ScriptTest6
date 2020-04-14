using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
	using UnityEditor;
#endif

namespace _301_Base
{
	public class AAA : MonoBehaviour
	{

		private void OnEnable()
		{
			#if UNITY_EDITOR
			//EditorWindow.GetWindow<AAA2>();			
			#endif 
		}
	}
}
