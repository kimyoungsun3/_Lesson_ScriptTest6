using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace _300_CustomInspector
{
	[CustomEditor(typeof(LevelScript))]
	public class LevelScriptEditor : Editor
	{
		LevelScript scp;
		private void OnEnable()
		{
			Debug.Log(this + " OnEnable");
			scp = (LevelScript)target;
		}

		public override void OnInspectorGUI()
		{
			Debug.Log(this + " OnInspectorGUI");
			base.OnInspectorGUI();

			//공격력 수치를 표시..
			EditorGUILayout.LabelField("공격력", scp.att.ToString());

			//script.experience = EditorGUILayout.IntField("Experience", _scp.experience);
			//EditorGUILayout.LabelField("Level", script.level.ToString());
		}

		public void OnSceneGUI()
		{
			Debug.Log(this + " OnSceneGUI");

		}

		private void OnDisable()
		{
			Debug.Log(this + " OnDisable");

		}
	}
}