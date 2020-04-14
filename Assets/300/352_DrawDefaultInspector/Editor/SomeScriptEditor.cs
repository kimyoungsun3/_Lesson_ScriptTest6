using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(SomeScript))]
public class SomeScriptEditor : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector ();
		EditorGUILayout.HelpBox ("This is a help box", MessageType.Info);


		/*
		SomeScript _scp = (SomeScript)target;
		_scp.level 	= EditorGUILayout.IntField ("Level", _scp.level);
		_scp.health	= EditorGUILayout.FloatField ("Health", _scp.health);
		_scp.target = EditorGUILayout.Vector3Field ("Target", _scp.target);
		*/
	}
}

