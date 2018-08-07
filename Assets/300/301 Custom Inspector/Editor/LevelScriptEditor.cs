using System.Collections;
using System.Collections.Generic;
//using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelScript))]
public class LevelScriptEditor : Editor {

	public override void OnInspectorGUI(){
		LevelScript _scp = (LevelScript)target;

		_scp.experience = EditorGUILayout.IntField ("Experience", _scp.experience);
		EditorGUILayout.LabelField ("Level", _scp.level.ToString());
	}
}
